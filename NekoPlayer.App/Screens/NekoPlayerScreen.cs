// Copyright (c) 2026 BoomboxRapsody <boomboxrapsody@gmail.com>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using osu.Framework.Screens;

namespace NekoPlayer.App.Screens
{
    public abstract partial class NekoPlayerScreen : Screen, INekoPlayerScreen
    {
        protected new NekoPlayerAppBase Game => base.Game as NekoPlayerAppBase;

        public virtual bool CursorVisible => true;
    }
}
