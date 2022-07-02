﻿using Reloaded.Mod.Launcher.Interop;
using Sewer56.UI.Controller.Core.Enums;
using Sewer56.UI.Controller.ReloadedInput.Configurator;
using Sewer56.UI.Controller.ReloadedInput.Enums;

namespace Reloaded.Mod.Launcher.Utility;

internal class ReloadedInputLocalizationProvider : ILocalizationProvider
{
    public XamlResourceProvider _xamlResourceProvider = new ();

    public string? GetName(Button button)
    {
        return _xamlResourceProvider.Get<string>($"ConfiguratorBtn{button.ToStringFast()}Name");
    }

    public string? GetDescription(Button button)
    {
        return _xamlResourceProvider.Get<string>($"ConfiguratorBtn{button.ToStringFast()}Description");
    }

    public string? GetName(CustomStickMappingEntry entry)
    {
        return _xamlResourceProvider.Get<string>($"ConfiguratorStick{entry}Name");
    }

    public string? GetDescription(CustomStickMappingEntry entry)
    {
        return _xamlResourceProvider.Get<string>($"ConfiguratorStick{entry}Description");
    }

    public string? GetCustomString(CustomStrings customString)
    {
        return _xamlResourceProvider.Get<string>($"ConfiguratorCustomString{customString}");
    }
}