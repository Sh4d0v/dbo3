using Intersect.Client.Core;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.Interface.Shared;
using Intersect.Client.Localization;
using Intersect.Client.Networking;
using Intersect.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Security;
using System.Net.Http;
using System.Threading.Tasks;

namespace Intersect.Client.Interface.Menu;

public partial class MenuGuiBase : IMutableInterface
{
    private readonly Canvas _menuCanvas;
    private readonly ImagePanel _serverStatusArea;
    private readonly Label _serverStatusLabel;
    private readonly VersionPanel _versionPanel;
    private readonly ImagePanel _newsWindow;
    private readonly Label _newsLabel;

    public MainMenu MainMenu { get; }

    private bool _shouldReset;

    public MenuGuiBase(Canvas myCanvas)
    {
        _menuCanvas = myCanvas;

        MainMenu = new MainMenu(_menuCanvas);

        _versionPanel = new VersionPanel(_menuCanvas, name: nameof(_versionPanel));

        _newsWindow = new ImagePanel(_menuCanvas, "MainMenuNews")
        {
            IsHidden = ClientContext.IsSinglePlayer,
        };
        _newsLabel = new Label(_newsWindow, "NewsLabel")
        {
            IsHidden = ClientContext.IsSinglePlayer,
        };
        _serverStatusArea = new ImagePanel(_menuCanvas, "ServerStatusArea")
        {
            IsHidden = ClientContext.IsSinglePlayer,
        };
        _serverStatusLabel = new Label(_serverStatusArea, "ServerStatusLabel")
        {
            IsHidden = ClientContext.IsSinglePlayer,
            Text = Strings.Server.StatusLabel.ToString(MainMenu.ActiveNetworkStatus.ToLocalizedString()),
        };

        _serverStatusArea.LoadJsonUi(GameContentManager.UI.Menu, Graphics.Renderer?.GetResolutionString());
        _newsWindow.LoadJsonUi(GameContentManager.UI.Menu, Graphics.Renderer?.GetResolutionString());
        _newsLabel.Text = "...";
        _ = LoadNewsAsync(); // updating news with news.txt

        MainMenu.NetworkStatusChanged += HandleNetworkStatusChanged;
    }

    ~MenuGuiBase()
    {
        // ReSharper disable once DelegateSubtraction
        MainMenu.NetworkStatusChanged -= HandleNetworkStatusChanged;
    }

    private void HandleNetworkStatusChanged()
    {
        _serverStatusLabel.Text = Strings.Server.StatusLabel.ToString(MainMenu.ActiveNetworkStatus.ToLocalizedString());
    }
    private async Task LoadNewsAsync()
    {
        try
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (request, cert, chain, errors) =>
                {
                    try
                    {
                        // Corrected access to RequestUri - 'request' is an HttpRequestMessage
                        if (request?.RequestUri?.IsLoopback == true)
                        {
                            return true;
                        }
                    }
                    catch
                    {
                        // Do not abort validation when there are issues reading the Uri.
                    }

                    return errors == SslPolicyErrors.None;
                }
            };

            using var client = new HttpClient(handler)
            {
                Timeout = TimeSpan.FromSeconds(10)
            };

            var uri = new Uri("https://localhost:5443/news.txt");
            string text = await client.GetStringAsync(uri).ConfigureAwait(false);

            // If the UI update must be performed on the main thread, do so appropriately.
            _newsLabel.Text = text;
            ApplicationContext.Context.Value?.Logger.LogInformation($"[NEWS] News downloaded: {text}");
        }
        catch (Exception ex)
        {
            ApplicationContext.Context.Value?.Logger.LogWarning(ex, "[NEWS] News cannot be downloaded");
            _newsLabel.Text = "";
            try
            {
                _newsLabel.Hide();
                _newsWindow.Hide();
            }
            catch
            {
                // ignore
            }
        }
    }

    public void Update(TimeSpan elapsed, TimeSpan total)
    {
        if (_shouldReset)
        {
            MainMenu.Reset();
            _shouldReset = false;
        }

        MainMenu.Update(elapsed, total);
    }

    public void Draw(TimeSpan elapsed, TimeSpan total)
    {
        _menuCanvas.RenderCanvas(elapsed, total);
    }

    public void Reset()
    {
        _shouldReset = true;
    }

    //Dispose
    public void Dispose()
    {
        _menuCanvas.Dispose();
    }

    /// <inheritdoc />
    public IReadOnlyList<Base> Children => MainMenu.Children;

    /// <inheritdoc />
    public TElement Create<TElement>(params object[] parameters) where TElement : Base =>
        MainMenu.Create<TElement>(parameters);

    /// <inheritdoc />
    public TElement? Find<TElement>(string? name = null, bool recurse = false) where TElement : Base =>
        MainMenu.Find<TElement>(name, recurse);

    /// <inheritdoc />
    public IEnumerable<TElement?> FindAll<TElement>(bool recurse = false) where TElement : Base =>
        MainMenu.FindAll<TElement>(recurse);

    /// <inheritdoc />
    public void Remove<TElement>(TElement element, bool dispose = false) where TElement : Base =>
        MainMenu.Remove(element, dispose);
}