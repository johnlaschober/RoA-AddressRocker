using RoA.Points.PointCollections;
using RoA.Screen;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Points.PointObjects
{
    public class PO_CSSSlot
    {
        private int playerNumber = -1;
        private PointCollectionsGroup slotTypeGroup;
        private Color slotActiveColor = Color.White;

        private PointCollectionsGroup slotAbsa;
        private PointCollectionsGroup slotClairen;
        private PointCollectionsGroup slotElliana;
        private PointCollectionsGroup slotEtalus;
        private PointCollectionsGroup slotForsburn;
        private PointCollectionsGroup slotHodan;
        private PointCollectionsGroup slotKragg;
        private PointCollectionsGroup slotMaypul;
        private PointCollectionsGroup slotMollo;
        private PointCollectionsGroup slotOlympia;
        private PointCollectionsGroup slotOrcane;
        private PointCollectionsGroup slotOri;
        private PointCollectionsGroup slotPomme;
        private PointCollectionsGroup slotRandom;
        private PointCollectionsGroup slotRanno;
        private PointCollectionsGroup slotShovelKnight;
        private PointCollectionsGroup slotSylvanos;
        private PointCollectionsGroup slotWrastor;
        private PointCollectionsGroup slotZetterburn;

        public PO_CSSSlot(int playerNumber)
        {
            this.playerNumber = playerNumber;

            Point slotStart = new Point(0, 0);
            if (playerNumber == 1)
            {
                slotStart = new Point(28, 632);
                slotActiveColor = ColorTranslator.FromHtml("#ED1C24");
            }
            if (playerNumber == 2)
            {
                slotStart = new Point(504, 632);
                slotActiveColor = ColorTranslator.FromHtml("#00B7EF");
            }

            slotTypeGroup = PointHelper.GetGroupClone(PC_Slot.Group);
            PointHelper.SlideGroup(slotStart, ref slotTypeGroup);

            slotAbsa = PointHelper.GetGroupClone(PC_SlotAbsa.Group);
            PointHelper.SlideGroup(slotStart, ref slotAbsa);

            slotClairen = PointHelper.GetGroupClone(PC_SlotClairen.Group);
            PointHelper.SlideGroup(slotStart, ref slotClairen);

            slotElliana = PointHelper.GetGroupClone(PC_SlotElliana.Group);
            PointHelper.SlideGroup(slotStart, ref slotElliana);

            slotEtalus = PointHelper.GetGroupClone(PC_SlotEtalus.Group);
            PointHelper.SlideGroup(slotStart, ref slotEtalus);

            slotForsburn = PointHelper.GetGroupClone(PC_SlotForsburn.Group);
            PointHelper.SlideGroup(slotStart, ref slotForsburn);

            slotHodan = PointHelper.GetGroupClone(PC_SlotHodan.Group);
            PointHelper.SlideGroup(slotStart, ref slotHodan);

            slotKragg = PointHelper.GetGroupClone(PC_SlotKragg.Group);
            PointHelper.SlideGroup(slotStart, ref slotKragg);

            slotMaypul = PointHelper.GetGroupClone(PC_SlotMaypul.Group);
            PointHelper.SlideGroup(slotStart, ref slotMaypul);

            slotMollo = PointHelper.GetGroupClone(PC_SlotMollo.Group);
            PointHelper.SlideGroup(slotStart, ref slotMollo);

            slotOlympia = PointHelper.GetGroupClone(PC_SlotOlympia.Group);
            PointHelper.SlideGroup(slotStart, ref slotOlympia);

            slotOrcane = PointHelper.GetGroupClone(PC_SlotOrcane.Group);
            PointHelper.SlideGroup(slotStart, ref slotOrcane);

            slotOri = PointHelper.GetGroupClone(PC_SlotOri.Group);
            PointHelper.SlideGroup(slotStart, ref slotOri);

            slotPomme = PointHelper.GetGroupClone(PC_SlotPomme.Group);
            PointHelper.SlideGroup(slotStart, ref slotPomme);

            slotRandom = PointHelper.GetGroupClone(PC_SlotRandom.Group);
            PointHelper.SlideGroup(slotStart, ref slotRandom);

            slotRanno = PointHelper.GetGroupClone(PC_SlotRanno.Group);
            PointHelper.SlideGroup(slotStart, ref slotRanno);

            slotShovelKnight = PointHelper.GetGroupClone(PC_SlotShovelKnight.Group);
            PointHelper.SlideGroup(slotStart, ref slotShovelKnight);

            slotSylvanos = PointHelper.GetGroupClone(PC_SlotSylvanos.Group);
            PointHelper.SlideGroup(slotStart, ref slotSylvanos);

            slotWrastor = PointHelper.GetGroupClone(PC_SlotWrastor.Group);
            PointHelper.SlideGroup(slotStart, ref slotWrastor);

            slotZetterburn = PointHelper.GetGroupClone(PC_SlotZetterburn.Group);
            PointHelper.SlideGroup(slotStart, ref slotZetterburn);
        }

        public string GetSlotType(Bitmap screen)
        {
            slotTypeGroup.collections[0].color = slotActiveColor;
            double dblActive = ScreenTools.GetMatchingPercentage(screen, slotTypeGroup);
            if (dblActive > 50) return "HMN";

            slotTypeGroup.collections[0].color = ColorTranslator.FromHtml("#808080"); // CPU gray
            double dblComputer = ScreenTools.GetMatchingPercentage(screen, slotTypeGroup);
            if (dblComputer > 50) return "CPU";

            return "OFF";
        }

        public string GetSlotCharacter(Bitmap screen)
        {
            Dictionary<string, double> dctCharacters = new Dictionary<string, double>();

            dctCharacters["ABSA"] = ScreenTools.GetMatchingPercentage(screen, slotAbsa);
            dctCharacters["CLAIREN"] = ScreenTools.GetMatchingPercentage(screen, slotClairen);
            dctCharacters["ELLIANA"] = ScreenTools.GetMatchingPercentage(screen, slotElliana);
            dctCharacters["ETALUS"] = ScreenTools.GetMatchingPercentage(screen, slotEtalus);
            dctCharacters["FORSBURN"] = ScreenTools.GetMatchingPercentage(screen, slotForsburn);
            dctCharacters["HODAN"] = ScreenTools.GetMatchingPercentage(screen, slotHodan);
            dctCharacters["KRAGG"] = ScreenTools.GetMatchingPercentage(screen, slotKragg);
            dctCharacters["MAYPUL"] = ScreenTools.GetMatchingPercentage(screen, slotMaypul);
            dctCharacters["MOLLO"] = ScreenTools.GetMatchingPercentage(screen, slotMollo);
            dctCharacters["OLYMPIA"] = ScreenTools.GetMatchingPercentage(screen, slotOlympia);
            dctCharacters["ORCANE"] = ScreenTools.GetMatchingPercentage(screen, slotOrcane);
            dctCharacters["ORI AND SEIN"] = ScreenTools.GetMatchingPercentage(screen, slotOri);
            dctCharacters["POMME"] = ScreenTools.GetMatchingPercentage(screen, slotPomme);
            dctCharacters["RANDOM"] = ScreenTools.GetMatchingPercentage(screen, slotRandom);
            dctCharacters["RANNO"] = ScreenTools.GetMatchingPercentage(screen, slotRanno);
            dctCharacters["SHOVEL KNIGHT"] = ScreenTools.GetMatchingPercentage(screen, slotShovelKnight);
            dctCharacters["SYLVANOS"] = ScreenTools.GetMatchingPercentage(screen, slotSylvanos);
            dctCharacters["WRASTOR"] = ScreenTools.GetMatchingPercentage(screen, slotWrastor);
            dctCharacters["ZETTERBURN"] = ScreenTools.GetMatchingPercentage(screen, slotZetterburn);

            return dctCharacters.OrderByDescending(k => k.Value).ToList().First().Key;
        }
    }
}
