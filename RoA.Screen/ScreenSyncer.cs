using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoA.Points.PointScreens;
using RoA.Points.PointObjects;

namespace RoA.Screen
{
    public class ScreenSyncer
    {
        private Screens screens;
        private Objects objects;

        public ScreenSyncer()
        {
            screens = new Screens();
            objects = new Objects();
        }

        public ScreenState Sync(Bitmap screen, ScreenState prevState)
        {
            ScreenState newState;

            if (prevState != null)
            {
                newState = prevState.GetCopy();
            }
            else
            {
                newState = new ScreenState();
            }

            if (screens.localCSS.IsActive(screen))
            {
                newState.ScreenName = "LOCAL CSS";
                newState.P1Character = objects.slot_p1.GetSlotCharacter(screen);
                newState.P2Character = objects.slot_p2.GetSlotCharacter(screen);

                if (newState.P1Character == "UNKNOWN") newState.P1Character = prevState.P1Character;
                if (newState.P2Character == "UNKNOWN") newState.P2Character = prevState.P2Character;
            }
            else if (screens.localSettings.IsActive(screen))
            {
                newState.ScreenName = "LOCAL SETTINGS";
            }
            else if (screens.stageSelect.IsActive(screen))
            {
                newState.ScreenName = "STAGE SELECT";
            }
            else if (screens.localMatch.IsActive(screen))
            {
                newState.ScreenName = "LOCAL MATCH";
            }
            else if (screens.pause.IsActive(screen))
            {
                newState.ScreenName = "PAUSE";
            }

            return newState;
        }
    }

    public class Screens
    {
        public PS_LocalVersusCSS localCSS;
        public PS_StageSelect stageSelect;
        public PS_LocalVersusMatch localMatch;
        public PS_Pause pause;
        public PS_LocalVersusSettings localSettings;

        public Screens()
        {
            localCSS = new PS_LocalVersusCSS();
            stageSelect = new PS_StageSelect();
            localMatch = new PS_LocalVersusMatch();
            pause = new PS_Pause();
            localSettings = new PS_LocalVersusSettings();
        }
    }

    public class Objects
    {
        public PO_CSSSlot slot_p1;
        public PO_CSSSlot slot_p2;

        public Objects()
        {
            slot_p1 = new PO_CSSSlot(1);
            slot_p2 = new PO_CSSSlot(2);
        }
    }
}
