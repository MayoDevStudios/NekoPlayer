// Copyright (c) 2026 BoomboxRapsody <boomboxrapsody@gmail.com>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Threading.Tasks;
using NekoPlayer.App;
using NekoPlayer.App.Extensions;
using NekoPlayer.App.Updater;
using NekoPlayer.Desktop.Updater;

namespace NekoPlayer.Desktop
{
    internal partial class NekoPlayerAppDesktop : NekoPlayerApp
    {
        protected override UpdateManager CreateUpdateManager() => new VelopackUpdateManager();

        public override bool RestartAppWhenExited()
        {
            Task.Run(() => Velopack.UpdateExe.Start(waitPid: (uint)Environment.ProcessId)).FireAndForget();
            return true;
        }
    }
}
