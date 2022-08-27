using RoA.Points.PointCollections;
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
            if (playerNumber == 3)
            {
                slotStart = new Point(980, 632);
                slotActiveColor = ColorTranslator.FromHtml("#FFA3B1");
            }
            if (playerNumber == 4)
            {
                slotStart = new Point(1456, 632);
                slotActiveColor = ColorTranslator.FromHtml("#A8E61D");
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

            var matching = dctCharacters.Where(k => k.Value >= 100).ToList();

            if (matching.Count > 0)
            {
                return matching.First().Key;
            }
            else
            {
                switch (playerNumber)
                {
                    case 1:
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.AbsaP1) >= 100) return "ABSA";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.ClairenP1) >= 100) return "CLAIREN";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.EllianaP1) >= 100) return "ELLIANA";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.EtalusP1) >= 100) return "ETALUS";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.ForsburnP1) >= 100) return "FORSBURN";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.HodanP1) >= 100) return "HODAN";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.KraggP1) >= 100) return "KRAGG";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.MaypulP1) >= 100) return "MAYPUL";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.MolloP1) >= 100) return "MOLLO";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.OlympiaP1) >= 100) return "OLYMPIA";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.OrcaneP1) >= 100) return "ORCANE";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.OriP1) >= 100) return "ORI AND SEIN";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.PommeP1) >= 100) return "POMME";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.RandomP1) >= 100) return "RANDOM";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.RannoP1) >= 100) return "RANNO";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.ShovelKnightP1) >= 100) return "SHOVEL KNIGHT";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.SylvanosP1) >= 100) return "SYLVANOS";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.WrastorP1) >= 100) return "WRASTOR";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.ZetterburnP1) >= 100) return "ZETTERBURN";
                        return "UNKNOWN";
                    case 2:
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.AbsaP2) >= 100) return "ABSA";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.ClairenP2) >= 100) return "CLAIREN";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.EllianaP2) >= 100) return "ELLIANA";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.EtalusP2) >= 100) return "ETALUS";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.ForsburnP2) >= 100) return "FORSBURN";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.HodanP2) >= 100) return "HODAN";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.KraggP2) >= 100) return "KRAGG";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.MaypulP2) >= 100) return "MAYPUL";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.MolloP2) >= 100) return "MOLLO";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.OlympiaP2) >= 100) return "OLYMPIA";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.OrcaneP2) >= 100) return "ORCANE";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.OriP2) >= 100) return "ORI AND SEIN";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.PommeP2) >= 100) return "POMME";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.RandomP2) >= 100) return "RANDOM";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.RannoP2) >= 100) return "RANNO";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.ShovelKnightP2) >= 100) return "SHOVEL KNIGHT";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.SylvanosP2) >= 100) return "SYLVANOS";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.WrastorP2) >= 100) return "WRASTOR";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.ZetterburnP2) >= 100) return "ZETTERBURN";
                        return "UNKNOWN";
                    case 3:
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.AbsaP3) >= 100) return "ABSA";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.ClairenP3) >= 100) return "CLAIREN";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.EllianaP3) >= 100) return "ELLIANA";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.EtalusP3) >= 100) return "ETALUS";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.ForsburnP3) >= 100) return "FORSBURN";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.HodanP3) >= 100) return "HODAN";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.KraggP3) >= 100) return "KRAGG";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.MaypulP3) >= 100) return "MAYPUL";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.MolloP3) >= 100) return "MOLLO";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.OlympiaP3) >= 100) return "OLYMPIA";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.OrcaneP3) >= 100) return "ORCANE";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.OriP3) >= 100) return "ORI AND SEIN";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.PommeP3) >= 100) return "POMME";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.RandomP3) >= 100) return "RANDOM";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.RannoP3) >= 100) return "RANNO";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.ShovelKnightP3) >= 100) return "SHOVEL KNIGHT";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.SylvanosP3) >= 100) return "SYLVANOS";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.WrastorP3) >= 100) return "WRASTOR";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.ZetterburnP3) >= 100) return "ZETTERBURN";
                        return "UNKNOWN";
                    case 4:
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.AbsaP4) >= 100) return "ABSA";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.ClairenP4) >= 100) return "CLAIREN";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.EllianaP4) >= 100) return "ELLIANA";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.EtalusP4) >= 100) return "ETALUS";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.ForsburnP4) >= 100) return "FORSBURN";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.HodanP4) >= 100) return "HODAN";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.KraggP4) >= 100) return "KRAGG";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.MaypulP4) >= 100) return "MAYPUL";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.MolloP4) >= 100) return "MOLLO";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.OlympiaP4) >= 100) return "OLYMPIA";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.OrcaneP4) >= 100) return "ORCANE";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.OriP4) >= 100) return "ORI AND SEIN";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.PommeP4) >= 100) return "POMME";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.RandomP4) >= 100) return "RANDOM";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.RannoP4) >= 100) return "RANNO";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.ShovelKnightP4) >= 100) return "SHOVEL KNIGHT";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.SylvanosP4) >= 100) return "SYLVANOS";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.WrastorP4) >= 100) return "WRASTOR";
                        if (ScreenTools.GetMatchingPercentage(screen, PC_FallbackTokens.ZetterburnP4) >= 100) return "ZETTERBURN";
                        return "UNKNOWN";
                }

                return "UNKNOWN";
            }
        }
    }
}
