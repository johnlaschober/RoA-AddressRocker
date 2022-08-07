﻿using RoA.Screen;
using System.Collections.Generic;
using System.Drawing;

namespace RoA.Points.PointCollections
{
    public static class PC_P1Hud // Red HUD in P1 vs P2
    {
        public static PointCollectionsGroup Group = new PointCollectionsGroup()
        {
            collections = new List<PointCollection>()
            {
                new PointCollection() // Black border
                {
                    color = Color.Black,
                    points = new List<Point>()
                    {
new Point(500, 1004),
new Point(500, 1005),
new Point(500, 1006),
new Point(500, 1007),
new Point(500, 1008),
new Point(500, 1009),
new Point(500, 1010),
new Point(500, 1011),
new Point(500, 1012),
new Point(500, 1013),
new Point(500, 1014),
new Point(500, 1015),
new Point(500, 1016),
new Point(500, 1017),
new Point(500, 1018),
new Point(500, 1019),
new Point(500, 1020),
new Point(500, 1021),
new Point(500, 1022),
new Point(500, 1023),
new Point(500, 1024),
new Point(500, 1025),
new Point(500, 1026),
new Point(500, 1027),
new Point(500, 1028),
new Point(500, 1029),
new Point(500, 1030),
new Point(500, 1031),
new Point(500, 1032),
new Point(500, 1033),
new Point(500, 1034),
new Point(500, 1035),
new Point(500, 1036),
new Point(500, 1037),
new Point(500, 1038),
new Point(500, 1039),
new Point(500, 1040),
new Point(500, 1041),
new Point(500, 1042),
new Point(500, 1043),
new Point(500, 1044),
new Point(500, 1045),
new Point(500, 1046),
new Point(500, 1047),
new Point(500, 1048),
new Point(500, 1049),
new Point(500, 1050),
new Point(500, 1051),
new Point(500, 1052),
new Point(500, 1053),
new Point(500, 1054),
new Point(500, 1055),
new Point(500, 1056),
new Point(500, 1057),
new Point(500, 1058),
new Point(500, 1059),
new Point(504, 992),
new Point(504, 993),
new Point(504, 994),
new Point(504, 995),
new Point(504, 996),
new Point(504, 997),
new Point(504, 998),
new Point(504, 999),
new Point(504, 1000),
new Point(504, 1001),
new Point(504, 1002),
new Point(504, 1003),
new Point(504, 1060),
new Point(504, 1061),
new Point(504, 1062),
new Point(504, 1063),
new Point(504, 1064),
new Point(504, 1065),
new Point(504, 1066),
new Point(504, 1067),
new Point(504, 1068),
new Point(504, 1069),
new Point(504, 1070),
new Point(504, 1071),
new Point(508, 988),
new Point(508, 989),
new Point(508, 990),
new Point(508, 991),
new Point(508, 1072),
new Point(508, 1073),
new Point(508, 1074),
new Point(508, 1075),
new Point(512, 984),
new Point(512, 985),
new Point(512, 986),
new Point(512, 987),
new Point(512, 1076),
new Point(512, 1077),
new Point(512, 1078),
new Point(512, 1079),
new Point(529, 1079),
new Point(530, 1079),
new Point(531, 1079),
new Point(532, 1079),
new Point(533, 1079),
new Point(534, 1079),
new Point(535, 1079),
new Point(536, 1079),
new Point(537, 1079),
new Point(538, 984),
new Point(538, 1079),
new Point(539, 984),
new Point(539, 1079),
new Point(540, 984),
new Point(540, 1079),
new Point(541, 984),
new Point(541, 1079),
new Point(542, 984),
new Point(542, 1079),
new Point(543, 984),
new Point(632, 1067),
new Point(633, 1067),
new Point(634, 1067),
new Point(635, 1067),
new Point(636, 1067),
new Point(637, 1067),
new Point(666, 984),
new Point(667, 984),
new Point(668, 984),
new Point(669, 984),
new Point(670, 984),
new Point(671, 984),
new Point(672, 984),
new Point(673, 984),
new Point(674, 984),
new Point(675, 984),
new Point(676, 984),
new Point(677, 984),
new Point(678, 984),
new Point(679, 984),
new Point(680, 984),
new Point(681, 984),
new Point(682, 984),
new Point(683, 984),
new Point(684, 984),
new Point(692, 996),
new Point(693, 996),
new Point(694, 996),
new Point(695, 996),
new Point(696, 996),
new Point(698, 1067),
new Point(699, 1067),
new Point(700, 1067),
new Point(701, 1067),
new Point(702, 1067),
new Point(703, 1067),
new Point(704, 1067),
new Point(832, 996),
new Point(833, 996),
new Point(834, 996),
new Point(835, 996),
new Point(836, 996),
new Point(837, 996),
new Point(838, 996),
new Point(839, 996),
new Point(840, 996),
new Point(841, 996),
new Point(848, 1079),
new Point(849, 1079),
new Point(850, 1079),
new Point(851, 1079),
new Point(852, 1079),
new Point(853, 1079),
new Point(854, 1079),
new Point(855, 1079),
new Point(856, 1079),
new Point(857, 1079),
new Point(858, 1079),
new Point(859, 1079),
new Point(860, 1079),
new Point(861, 1079),
new Point(862, 1079),
new Point(863, 1079),
new Point(864, 1079),
new Point(865, 1079),
new Point(931, 1009),
new Point(931, 1010),
new Point(931, 1011),
new Point(931, 1012),
new Point(931, 1013),
new Point(931, 1014),
new Point(931, 1015),
new Point(935, 984),
new Point(935, 985),
new Point(935, 986),
new Point(935, 987),
new Point(935, 1076),
new Point(935, 1077),
new Point(935, 1078),
new Point(935, 1079),
new Point(939, 988),
new Point(939, 989),
new Point(939, 990),
new Point(939, 991),
new Point(939, 1072),
new Point(939, 1073),
new Point(939, 1074),
new Point(939, 1075),
new Point(943, 992),
new Point(943, 993),
new Point(943, 994),
new Point(943, 995),
new Point(943, 996),
new Point(943, 997),
new Point(943, 998),
new Point(943, 999),
new Point(943, 1000),
new Point(943, 1001),
new Point(943, 1002),
new Point(943, 1003),
new Point(943, 1060),
new Point(943, 1061),
new Point(943, 1062),
new Point(943, 1063),
new Point(943, 1064),
new Point(943, 1065),
new Point(943, 1066),
new Point(943, 1067),
new Point(943, 1068),
new Point(943, 1069),
new Point(943, 1070),
new Point(943, 1071),
new Point(947, 1004),
new Point(947, 1005),
new Point(947, 1006),
new Point(947, 1007),
new Point(947, 1008),
new Point(947, 1009),
new Point(947, 1010),
new Point(947, 1011),
new Point(947, 1012),
new Point(947, 1013),
new Point(947, 1014),
new Point(947, 1015),
new Point(947, 1016),
new Point(947, 1017),
new Point(947, 1018),
new Point(947, 1019),
new Point(947, 1020),
new Point(947, 1021),
new Point(947, 1022),
new Point(947, 1023),
new Point(947, 1024),
new Point(947, 1025),
new Point(947, 1026),
new Point(947, 1027),
new Point(947, 1028),
new Point(947, 1029),
new Point(947, 1030),
new Point(947, 1031),
new Point(947, 1032),
new Point(947, 1033),
new Point(947, 1034),
new Point(947, 1035),
new Point(947, 1036),
new Point(947, 1037),
new Point(947, 1038),
new Point(947, 1039),
new Point(947, 1040),
new Point(947, 1041),
new Point(947, 1042),
new Point(947, 1043),
new Point(947, 1044),
new Point(947, 1045),
new Point(947, 1046),
new Point(947, 1047),
new Point(947, 1048),
new Point(947, 1049),
new Point(947, 1050),
new Point(947, 1051),
new Point(947, 1052),
new Point(947, 1053),
new Point(947, 1054),
new Point(947, 1055),
new Point(947, 1056),
new Point(947, 1057),
new Point(947, 1058),
new Point(947, 1059),

                    }
                },
                new PointCollection() // Red color
                {
                    color = ColorTranslator.FromHtml("#ED1C24"),
                    points = new List<Point>()
                    {
                        new Point(516, 1018),
new Point(516, 1019),
new Point(516, 1020),
new Point(516, 1021),
new Point(516, 1022),
new Point(516, 1023),
new Point(516, 1024),
new Point(516, 1025),
new Point(516, 1026),
new Point(516, 1027),
new Point(516, 1028),
new Point(516, 1029),
new Point(516, 1030),
new Point(516, 1031),
new Point(516, 1032),
new Point(516, 1033),
new Point(516, 1034),
new Point(516, 1035),
new Point(516, 1036),
new Point(516, 1037),
new Point(516, 1038),
new Point(516, 1039),
new Point(516, 1040),
new Point(516, 1041),
new Point(516, 1042),
new Point(516, 1043),
new Point(516, 1044),
new Point(516, 1045),
new Point(516, 1046),
new Point(516, 1047),
new Point(516, 1048),
new Point(517, 1007),
new Point(517, 1008),
new Point(517, 1009),
new Point(517, 1010),
new Point(517, 1011),
new Point(517, 1012),
new Point(517, 1013),
new Point(517, 1014),
new Point(517, 1015),
new Point(517, 1016),
new Point(517, 1017),
new Point(517, 1049),
new Point(517, 1050),
new Point(518, 999),
new Point(518, 1000),
new Point(518, 1001),
new Point(518, 1002),
new Point(518, 1003),
new Point(518, 1004),
new Point(518, 1005),
new Point(518, 1006),
new Point(519, 997),
new Point(519, 998),
new Point(520, 996),
new Point(520, 997),
new Point(521, 995),
new Point(522, 994),
new Point(522, 995),
new Point(523, 993),
new Point(523, 994),
new Point(524, 993),
new Point(525, 992),
new Point(525, 993),
new Point(526, 992),
new Point(527, 992),
new Point(528, 991),
new Point(529, 991),
new Point(530, 991),
new Point(531, 991),
new Point(532, 990),
new Point(533, 990),
new Point(533, 1071),
new Point(534, 990),
new Point(534, 1071),
new Point(535, 990),
new Point(535, 1071),
new Point(536, 990),
new Point(536, 1071),
new Point(537, 990),
new Point(537, 1070),
new Point(537, 1071),
new Point(538, 990),
new Point(538, 1070),
new Point(539, 990),
new Point(539, 1070),
new Point(540, 990),
new Point(540, 1070),
new Point(541, 990),
new Point(541, 1069),
new Point(542, 990),
new Point(542, 1069),
new Point(543, 990),
new Point(543, 1069),
new Point(544, 990),
new Point(544, 1069),
new Point(545, 991),
new Point(545, 1069),
new Point(546, 991),
new Point(546, 1069),
new Point(547, 992),
new Point(547, 1069),
new Point(548, 992),
new Point(548, 1068),
new Point(549, 992),
new Point(549, 993),
new Point(549, 1068),
new Point(550, 993),
new Point(550, 1021),
new Point(550, 1068),
new Point(551, 993),
new Point(551, 1021),
new Point(551, 1068),
new Point(552, 993),
new Point(552, 1020),
new Point(552, 1025),
new Point(552, 1026),
new Point(552, 1068),
new Point(553, 993),
new Point(553, 994),
new Point(553, 1019),
new Point(553, 1026),
new Point(553, 1027),
new Point(553, 1028),
new Point(553, 1068),
new Point(554, 995),
new Point(554, 1019),
new Point(554, 1029),
new Point(554, 1030),
new Point(554, 1066),
new Point(554, 1067),
new Point(555, 995),
new Point(555, 996),
new Point(555, 997),
new Point(555, 1019),
new Point(555, 1031),
new Point(555, 1032),
new Point(555, 1033),
new Point(555, 1065),
new Point(555, 1066),
new Point(556, 997),
new Point(556, 998),
new Point(556, 1018),
new Point(556, 1034),
new Point(556, 1035),
new Point(556, 1063),
new Point(556, 1064),
new Point(556, 1065),
new Point(557, 998),
new Point(557, 999),
new Point(557, 1000),
new Point(557, 1018),
new Point(557, 1036),
new Point(557, 1037),
new Point(557, 1038),
new Point(557, 1039),
new Point(557, 1062),
new Point(557, 1063),
new Point(558, 1000),
new Point(558, 1001),
new Point(558, 1002),
new Point(558, 1003),
new Point(558, 1017),
new Point(558, 1018),
new Point(558, 1040),
new Point(558, 1041),
new Point(558, 1042),
new Point(558, 1043),
new Point(558, 1056),
new Point(558, 1057),
new Point(558, 1058),
new Point(558, 1059),
new Point(558, 1060),
new Point(558, 1061),
new Point(559, 1004),
new Point(559, 1005),
new Point(559, 1006),
new Point(559, 1007),
new Point(559, 1008),
new Point(559, 1009),
new Point(559, 1010),
new Point(559, 1011),
new Point(559, 1012),
new Point(559, 1013),
new Point(559, 1014),
new Point(559, 1016),
new Point(559, 1017),
new Point(559, 1043),
new Point(559, 1044),
new Point(559, 1045),
new Point(559, 1046),
new Point(559, 1047),
new Point(559, 1048),
new Point(559, 1049),
new Point(559, 1050),
new Point(559, 1051),
new Point(559, 1052),
new Point(559, 1053),
new Point(559, 1054),
new Point(559, 1055),
new Point(560, 1014),
new Point(560, 1015),
new Point(587, 1071),
new Point(588, 1071),
new Point(589, 1071),
new Point(590, 1071),
new Point(591, 1071),
new Point(592, 1071),
new Point(593, 1071),
new Point(594, 1071),
new Point(595, 1071),
new Point(596, 1071),
new Point(597, 1071),
new Point(598, 1071),
new Point(599, 1071),
new Point(600, 1071),
new Point(601, 1071),
new Point(602, 1071),
new Point(603, 1071),
new Point(604, 1071),
new Point(605, 1071),
new Point(606, 1071),
new Point(607, 1071),
new Point(608, 1071),
new Point(609, 1071),
new Point(610, 1071),
new Point(611, 1071),
new Point(612, 1071),
new Point(613, 1071),
new Point(614, 1071),
new Point(615, 1071),
new Point(616, 1071),
new Point(617, 1071),
new Point(671, 993),
new Point(672, 993),
new Point(673, 993),
new Point(674, 993),
new Point(675, 993),
new Point(676, 993),
new Point(677, 993),
new Point(678, 992),
new Point(679, 992),
new Point(680, 992),
new Point(681, 992),
new Point(682, 992),
new Point(683, 992),
new Point(684, 992),
new Point(685, 992),
new Point(686, 992),
new Point(694, 1071),
new Point(695, 1071),
new Point(696, 1072),
new Point(697, 1072),
new Point(698, 1072),
new Point(699, 1072),
new Point(700, 1072),
new Point(701, 1072),
new Point(702, 1072),
new Point(703, 1072),
new Point(704, 1072),
new Point(705, 1072),
new Point(706, 1072),
new Point(707, 1072),
new Point(708, 1072),
new Point(709, 1072),
new Point(710, 1072),
new Point(711, 1072),
new Point(712, 1072),
new Point(713, 1072),
new Point(714, 1072),
new Point(715, 1072),
new Point(716, 1072),
new Point(717, 1072),
new Point(776, 1072),
new Point(777, 1072),
new Point(778, 1072),
new Point(779, 1072),
new Point(780, 1072),
new Point(781, 1071),
new Point(782, 1071),
new Point(783, 1071),
new Point(784, 1071),
new Point(785, 1071),
new Point(786, 1071),
new Point(787, 1071),
new Point(788, 1071),
new Point(789, 1071),
new Point(790, 1071),
new Point(791, 1071),
new Point(792, 1071),
new Point(793, 1071),
new Point(794, 1071),
new Point(795, 992),
new Point(795, 1071),
new Point(796, 992),
new Point(796, 1071),
new Point(797, 992),
new Point(797, 1071),
new Point(798, 992),
new Point(798, 1071),
new Point(799, 992),
new Point(799, 1071),
new Point(800, 992),
new Point(800, 1071),
new Point(801, 992),
new Point(801, 1071),
new Point(802, 992),
new Point(802, 1071),
new Point(803, 992),
new Point(803, 1071),
new Point(804, 992),
new Point(804, 1071),
new Point(805, 992),
new Point(805, 1071),
new Point(806, 992),
new Point(806, 1071),
new Point(807, 992),
new Point(807, 1071),
new Point(808, 992),
new Point(808, 1071),
new Point(809, 992),
new Point(809, 1071),
new Point(810, 992),
new Point(810, 1071),
new Point(811, 992),
new Point(811, 1071),
new Point(812, 992),
new Point(812, 1071),
new Point(813, 992),
new Point(813, 1071),
new Point(814, 992),
new Point(814, 1071),
new Point(815, 992),
new Point(815, 1071),
new Point(816, 992),
new Point(817, 992),
new Point(818, 992),
new Point(819, 992),
new Point(861, 1072),
new Point(862, 1072),
new Point(863, 1072),
new Point(864, 1072),
new Point(865, 1072),
new Point(866, 1072),
new Point(867, 1071),
new Point(868, 1071),
new Point(869, 1071),
new Point(870, 1071),
new Point(871, 1071),
new Point(872, 1071),
new Point(873, 1071),
new Point(874, 1071),
new Point(875, 1071),
new Point(876, 1071),
new Point(877, 1071),
new Point(878, 1071),
new Point(879, 1071),
new Point(880, 1071),
new Point(881, 1071),
new Point(896, 1049),
new Point(896, 1050),
new Point(896, 1051),
new Point(896, 1052),
new Point(896, 1053),
new Point(896, 1054),
new Point(896, 1055),
new Point(896, 1056),
new Point(896, 1057),
new Point(896, 1058),
new Point(896, 1069),
new Point(896, 1070),
new Point(896, 1071),
new Point(897, 1058),
new Point(897, 1059),
new Point(897, 1060),
new Point(897, 1061),
new Point(897, 1062),
new Point(897, 1063),
new Point(897, 1064),
new Point(897, 1065),
new Point(897, 1066),
new Point(897, 1067),
new Point(897, 1068),
new Point(897, 1069),
new Point(919, 1071),
new Point(920, 1070),
new Point(920, 1071),
new Point(921, 1070),
new Point(922, 1069),
new Point(923, 1069),
new Point(924, 1068),
new Point(924, 1069),
new Point(925, 1036),
new Point(925, 1068),
new Point(926, 1036),
new Point(926, 1037),
new Point(926, 1067),
new Point(926, 1068),
new Point(927, 1038),
new Point(927, 1067),
new Point(928, 1038),
new Point(928, 1067),
new Point(929, 1039),
new Point(929, 1066),
new Point(930, 1040),
new Point(930, 1065),
new Point(930, 1066),
new Point(931, 1041),
new Point(931, 1064),
new Point(931, 1065),
new Point(932, 1042),
new Point(932, 1063),
new Point(932, 1064),
new Point(933, 1043),
new Point(933, 1044),
new Point(933, 1063),
new Point(934, 1044),
new Point(934, 1045),
new Point(935, 1044),
new Point(935, 1045),
new Point(936, 1043),
new Point(936, 1044),
new Point(937, 1016),
new Point(937, 1017),
new Point(937, 1041),
new Point(937, 1042),
new Point(937, 1043),
new Point(938, 1017),
new Point(938, 1018),
new Point(938, 1019),
new Point(938, 1020),
new Point(938, 1021),
new Point(938, 1022),
new Point(938, 1023),
new Point(938, 1024),
new Point(938, 1025),
new Point(938, 1026),
new Point(938, 1027),
new Point(938, 1028),
new Point(938, 1029),
new Point(938, 1030),
new Point(938, 1038),
new Point(938, 1039),
new Point(938, 1040),
new Point(939, 1030),
new Point(939, 1031),
new Point(939, 1032),
new Point(939, 1033),
new Point(939, 1034),
new Point(939, 1035),
new Point(939, 1036),
new Point(939, 1037),
new Point(939, 1038)
                    }
                }
            }
        };
    }
}