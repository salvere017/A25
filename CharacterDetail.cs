using Microsoft.Data.Sqlite;
using System.Text;

namespace A25
{
    public partial class CharacterDetail : Form
    {
        public CharacterDetail(int character_id)
        {
            InitializeComponent();
            Init(character_id);
            img_load(character_id);
        }

        public void Init(int character_id)
        {
            using (var connection = new SqliteConnection(Common.DatabaseLocalPath))
            {
                connection.Open();
                // SQLコマンド対象
                var command = connection.CreateCommand();

                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT T0.CHARACTER, ").AppendLine();                                           //ITEM:00
                sql.Append("       T1.ATTRIBUTE, ").AppendLine();                                           //ITEM:01
                sql.Append("       T2.ROLE_NAME, ").AppendLine();                                           //ITEM:02
                sql.Append("       'スキル① : ' || T3.SKILL1_NAME AS SKILL1_NAME, ").AppendLine();         //ITEM:03
                sql.Append("       T3.SKILL1_TARGET_OBJ, ").AppendLine();                                   //ITEM:04
                sql.Append("       T3.SKILL1_DAMEGE, ").AppendLine();                                       //ITEM:05
                sql.Append("       T3.SKILL1_BREAK, ").AppendLine();                                        //ITEM:06
                sql.Append("       T3.SKILL1_RECOVERY, ").AppendLine();                                     //ITEM:07
                sql.Append("       T3.SKILL1_WEIGHT, ").AppendLine();                                       //ITEM:08
                sql.Append("       T3.SKILL1_COMMENT, ").AppendLine();                                      //ITEM:09
                sql.Append("       'スキル② : ' || T4.SKILL2_NAME AS SKILL2_NAME, ").AppendLine();         //ITEM:10
                sql.Append("       T4.SKILL2_TARGET_OBJ, ").AppendLine();                                   //ITEM:11
                sql.Append("       T4.SKILL2_DAMEGE, ").AppendLine();                                       //ITEM:12
                sql.Append("       T4.SKILL2_BREAK, ").AppendLine();                                        //ITEM:13
                sql.Append("       T4.SKILL2_RECOVERY, ").AppendLine();                                     //ITEM:14
                sql.Append("       T4.SKILL2_WEIGHT, ").AppendLine();                                       //ITEM:15
                sql.Append("       T4.SKILL2_COMMENT, ").AppendLine();                                      //ITEM:16
                sql.Append("       'スキル③ : ' || T5.SKILL3_NAME AS SKILL3_NAME, ").AppendLine();         //ITEM:17
                sql.Append("       T5.SKILL3_TARGET_OBJ, ").AppendLine();                                   //ITEM:18
                sql.Append("       T5.SKILL3_DAMEGE, ").AppendLine();                                       //ITEM:19
                sql.Append("       T5.SKILL3_BREAK, ").AppendLine();                                        //ITEM:20
                sql.Append("       T5.SKILL3_RECOVERY, ").AppendLine();                                     //ITEM:21
                sql.Append("       T5.SKILL3_WEIGHT, ").AppendLine();                                       //ITEM:22
                sql.Append("       T5.SKILL3_COMMENT, ").AppendLine();                                      //ITEM:23
                sql.Append("       T6.HP, ").AppendLine();                                                  //ITEM:24
                sql.Append("       T6.PHYSICS_ATTACK, ").AppendLine();                                      //ITEM:25
                sql.Append("       T6.PHYSICS_DENFENCE, ").AppendLine();                                    //ITEM:26
                sql.Append("       T6.MAGIC_ATTACK, ").AppendLine();                                        //ITEM:27
                sql.Append("       T6.MAGIC_DENFENCE, ").AppendLine();                                      //ITEM:28
                sql.Append("       T6.SPEED, ").AppendLine();                                               //ITEM:29
                sql.Append("       T7.ABILITY1, ").AppendLine();                                            //ITEM:30
                sql.Append("       T7.ABILITY1_COMMENT, ").AppendLine();                                    //ITEM:31
                sql.Append("       T7.ABILITY2, ").AppendLine();                                            //ITEM:32
                sql.Append("       T7.ABILITY2_COMMENT, ").AppendLine();                                    //ITEM:33
                sql.Append("       T8.GIFT_NAME1, ").AppendLine();                                          //ITEM:34
                sql.Append("       T8.GIFT_COMMENT1, ").AppendLine();                                       //ITEM:35
                sql.Append("       T9.GIFT_NAME2, ").AppendLine();                                          //ITEM:36
                sql.Append("       T9.GIFT_COMMENT2, ").AppendLine();                                       //ITEM:37
                sql.Append("       T10.GIFT_NAME3, ").AppendLine();                                         //ITEM:38
                sql.Append("       T10.GIFT_COMMENT3 ").AppendLine();                                       //ITEM:39
                sql.Append("FROM CHARA_BASE_INFO T0 ").AppendLine();
                sql.Append("LEFT OUTER JOIN ALL_ATTRIBUTE_MST T1 ").AppendLine(); // 属性
                sql.Append("ON T1.ATTRIBUTE_CODE = T0.ATTRIBUTE ").AppendLine();
                sql.Append("LEFT OUTER JOIN ALL_ROLE_MST T2 ").AppendLine(); //キャラカテゴリ
                sql.Append("ON T2.ROLE_CODE = T0.ROLE ").AppendLine();
                sql.Append("LEFT OUTER JOIN (SELECT T31.SKILL1_NAME     AS SKILL1_NAME, ").AppendLine();
                sql.Append("                        T31.CHARACTER_CODE  AS CHARACTER_CODE, ").AppendLine();
                sql.Append("                        T32.TARGET          AS SKILL1_TARGET_OBJ, ").AppendLine();
                sql.Append("                        T31.SKILL1_DAMEGE   AS SKILL1_DAMEGE, ").AppendLine();
                sql.Append("                        T31.SKILL1_BREAK    AS SKILL1_BREAK, ").AppendLine();
                sql.Append("                        T31.SKILL1_RECOVERY AS SKILL1_RECOVERY, ").AppendLine();
                sql.Append("                        T31.SKILL1_WEIGHT   AS SKILL1_WEIGHT, ").AppendLine();
                sql.Append("                        T31.SKILL1_COMMENT  AS SKILL1_COMMENT ").AppendLine();
                sql.Append("                 FROM CHARA_SKILL_INFO T31").AppendLine();
                sql.Append("                 LEFT OUTER JOIN ALL_TARGET_RANGE_MST T32").AppendLine();
                sql.Append("                 ON T31.SKILL1_TARGET_OBJ = T32.TARGET_OBJ_CODE").AppendLine();
                sql.Append("                ) T3 ").AppendLine(); //SKILL1部分
                sql.Append("ON T3.CHARACTER_CODE = T0.CHARACTER_CODE ").AppendLine();
                sql.Append("LEFT OUTER JOIN (SELECT T41.SKILL2_NAME     AS SKILL2_NAME, ").AppendLine();
                sql.Append("                        T41.CHARACTER_CODE  AS CHARACTER_CODE, ").AppendLine();
                sql.Append("                        T42.TARGET          AS SKILL2_TARGET_OBJ, ").AppendLine();
                sql.Append("                        T41.SKILL2_DAMEGE   AS SKILL2_DAMEGE, ").AppendLine();
                sql.Append("                        T41.SKILL2_BREAK    AS SKILL2_BREAK, ").AppendLine();
                sql.Append("                        T41.SKILL2_RECOVERY AS SKILL2_RECOVERY, ").AppendLine();
                sql.Append("                        T41.SKILL2_WEIGHT   AS SKILL2_WEIGHT, ").AppendLine();
                sql.Append("                        T41.SKILL2_COMMENT  AS SKILL2_COMMENT ").AppendLine();
                sql.Append("                 FROM CHARA_SKILL_INFO T41").AppendLine();
                sql.Append("                 LEFT OUTER JOIN ALL_TARGET_RANGE_MST T42 ").AppendLine();
                sql.Append("                 ON T41.SKILL1_TARGET_OBJ = T42.TARGET_OBJ_CODE ").AppendLine();
                sql.Append("                ) T4 ").AppendLine(); //SKILL2部分
                sql.Append("ON T4.CHARACTER_CODE = T0.CHARACTER_CODE ").AppendLine();
                sql.Append("LEFT OUTER JOIN (SELECT T51.SKILL3_NAME     AS SKILL3_NAME, ").AppendLine();
                sql.Append("                        T51.CHARACTER_CODE  AS CHARACTER_CODE, ").AppendLine();
                sql.Append("                        T52.TARGET          AS SKILL3_TARGET_OBJ, ").AppendLine();
                sql.Append("                        T51.SKILL3_DAMEGE   AS SKILL3_DAMEGE, ").AppendLine();
                sql.Append("                        T51.SKILL3_BREAK    AS SKILL3_BREAK, ").AppendLine();
                sql.Append("                        T51.SKILL3_RECOVERY AS SKILL3_RECOVERY, ").AppendLine();
                sql.Append("                        T51.SKILL3_WEIGHT   AS SKILL3_WEIGHT, ").AppendLine();
                sql.Append("                        T51.SKILL3_COMMENT  AS SKILL3_COMMENT ").AppendLine();
                sql.Append("                 FROM CHARA_SKILL_INFO T51").AppendLine();
                sql.Append("                 LEFT OUTER JOIN ALL_TARGET_RANGE_MST T52").AppendLine();
                sql.Append("                 ON T51.SKILL1_TARGET_OBJ = T52.TARGET_OBJ_CODE").AppendLine();
                sql.Append("                ) T5 ").AppendLine(); //SKILL3部分
                sql.Append("ON T5.CHARACTER_CODE = T0.CHARACTER_CODE ").AppendLine();
                sql.Append("LEFT OUTER JOIN CHARA_PROPERTIES T6 ").AppendLine(); //能力値部分
                sql.Append("ON T6.CHARACTER_CODE = T0.CHARACTER_CODE ").AppendLine();
                sql.Append("LEFT OUTER JOIN CHARA_ABILITY_INFO T7 ").AppendLine(); //アビリティ部分
                sql.Append("ON T7.CHARACTER_CODE = T0.CHARACTER_CODE ").AppendLine();
                sql.Append("LEFT OUTER JOIN (SELECT T82.GIFT_NAME AS GIFT_NAME1,").AppendLine();
                sql.Append("                        T82.GIFT_COMMENT AS GIFT_COMMENT1,").AppendLine();
                sql.Append("                        T81.CHARACTER_CODE").AppendLine();
                sql.Append("                 FROM CHARA_GIFT_INFO T81").AppendLine();
                sql.Append("                 LEFT OUTER JOIN ALL_GIFT_INFO_MST T82 ").AppendLine();
                sql.Append("                 ON T81.GIFT1 = T82.GIFT_ID ").AppendLine();
                sql.Append("                ) T8 ").AppendLine(); //錬金ギフト部分1
                sql.Append("ON T8.CHARACTER_CODE = T0.CHARACTER_CODE ").AppendLine();
                sql.Append("LEFT OUTER JOIN (SELECT T92.GIFT_NAME AS GIFT_NAME2,").AppendLine();
                sql.Append("                        T92.GIFT_COMMENT AS GIFT_COMMENT2,").AppendLine();
                sql.Append("                        T91.CHARACTER_CODE").AppendLine();
                sql.Append("                 FROM CHARA_GIFT_INFO T91").AppendLine();
                sql.Append("                 LEFT OUTER JOIN ALL_GIFT_INFO_MST T92 ").AppendLine();
                sql.Append("                 ON T91.GIFT2 = T92.GIFT_ID ").AppendLine();
                sql.Append("                ) T9 ").AppendLine(); //錬金ギフト部分2
                sql.Append("ON T9.CHARACTER_CODE = T0.CHARACTER_CODE ").AppendLine();
                sql.Append("LEFT OUTER JOIN (SELECT T102.GIFT_NAME AS GIFT_NAME3,").AppendLine();
                sql.Append("                        T102.GIFT_COMMENT AS GIFT_COMMENT3,").AppendLine();
                sql.Append("                        T101.CHARACTER_CODE").AppendLine();
                sql.Append("                 FROM CHARA_GIFT_INFO T101").AppendLine();
                sql.Append("                 LEFT OUTER JOIN ALL_GIFT_INFO_MST T102 ").AppendLine();
                sql.Append("                 ON T101.GIFT3 = T102.GIFT_ID ").AppendLine();
                sql.Append("                ) T10 ").AppendLine(); //錬金ギフト部分3
                sql.Append("ON T10.CHARACTER_CODE = T0.CHARACTER_CODE ").AppendLine();
                sql.Append("WHERE T0.CHARACTER_CODE = $CHARACTER_CODE").AppendLine();

                //SQL実行
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("$CHARACTER_CODE", character_id);
                command.ExecuteNonQuery();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            // DataTableデータバインド
                            label_character.Text = reader.GetString(0);
                            label_attribute_name.Text = reader.GetString(1);
                            label_role_name.Text = reader.GetString(2);
                            label_skill1.Text = reader.GetString(3);
                            label_range1.Text = reader.GetString(4);
                            label_damage1_value.Text = reader.GetString(5) + "%";
                            label_break1_value.Text = reader.GetString(6) + "%";
                            label_recovery1_value.Text = reader.GetString(7);
                            label_weight1_value.Text = reader.GetString(8);
                            label_effect1_value.Text = reader.GetString(9);
                            label_skill2.Text = reader.GetString(10);
                            label_range2.Text = reader.GetString(11);
                            label_damage2_value.Text = reader.GetString(12) + "%";
                            label_break2_value.Text = reader.GetString(13) + "%";
                            label_recovery2_value.Text = reader.GetString(14);
                            label_weight2_value.Text = reader.GetString(15);
                            label_effect2_value.Text = reader.GetString(16);
                            label_skill3.Text = reader.GetString(17);
                            label_range3.Text = reader.GetString(18);
                            label_damage3_value.Text = reader.GetString(19) + "%";
                            label_break3_value.Text = reader.GetString(20) + "%";
                            label_recovery3_value.Text = reader.GetString(21);
                            label_weight3_value.Text = reader.GetString(22);
                            label_effect3_value.Text = reader.GetString(23);
                            label_hp_value.Text = reader.GetString(24);
                            label_ph_attack_value.Text = reader.GetString(25);
                            label_ph_defend_value.Text = reader.GetString(26);
                            label_magic_atk_value.Text = reader.GetString(27);
                            label_magic_defend_value.Text = reader.GetString(28);
                            label_speed_value.Text = reader.GetString(29);
                            label_ability1_name.Text = reader.GetString(30);
                            label_ability1_value.Text = reader.GetString(31);
                            label_ability2_name.Text = reader.GetString(32);
                            label_ability2_value.Text = reader.GetString(33);
                            label_gift1_name.Text = reader.GetString(34);
                            label_gift1_value.Text = reader.GetString(35);
                            label_gift2_name.Text = reader.GetString(36);
                            label_gift2_value.Text = reader.GetString(37);
                            label_gift3_name.Text = reader.GetString(38);
                            label_gift3_value.Text = reader.GetString(39);
                            break;
                        }
                        catch
                        {
                            label_character.Text = reader.GetString(0);
                            label_attribute_name.Text = reader.GetString(1);
                            label_role_name.Text = reader.GetString(2);
                            label_skill1.Text = "";
                            label_range1.Text = "";
                            label_damage1_value.Text = "" + "%";
                            label_break1_value.Text = "" + "%";
                            label_recovery1_value.Text = "";
                            label_weight1_value.Text = "";
                            label_effect1_value.Text = "";
                            label_skill2.Text = "";
                            label_range2.Text = "";
                            label_damage2_value.Text = "" + "%";
                            label_break2_value.Text = "" + "%";
                            label_recovery2_value.Text = "";
                            label_weight2_value.Text = "";
                            label_effect2_value.Text = "";
                            label_skill3.Text = "";
                            label_range3.Text = "";
                            label_damage3_value.Text = "" + "%";
                            label_break3_value.Text = "" + "%";
                            label_recovery3_value.Text = "";
                            label_weight3_value.Text = "";
                            label_effect3_value.Text = "";
                            label_hp_value.Text = "";
                            label_ph_attack_value.Text = "";
                            label_ph_defend_value.Text = "";
                            label_magic_atk_value.Text = "";
                            label_magic_defend_value.Text = "";
                            label_speed_value.Text = "";
                            label_ability1_name.Text = "";
                            label_ability1_value.Text = "";
                            label_ability2_name.Text = "";
                            label_ability2_value.Text = "";
                            label_gift1_name.Text = "";
                            label_gift1_value.Text = "";
                            label_gift2_name.Text = "";
                            label_gift2_value.Text = "";
                            label_gift3_name.Text = "";
                            label_gift3_value.Text = "";
                            MessageBox.Show("データ欠損");
                            break;
                        }
                    }
                }
                connection.Close();
            }
        }

        private void img_load(int character_id)
        {
            using (var connection = new SqliteConnection(Common.DatabaseLocalPath))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = " SELECT AVATAR, ITEM_COLOR_LR FROM CHARA_IMG WHERE CHARACTER_CODE = @ID ";
                command.Parameters.AddWithValue("@ID", character_id);
                command.ExecuteNonQuery();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    byte[] data1 = (byte[])reader["AVATAR"];
                    byte[] data2 = (byte[])reader["ITEM_COLOR_LR"];
                    Bitmap bmp_avater1 = Common.ByteToImage(data1);
                    Bitmap bmp_avater2 = Common.ByteToImage(data2);

                    //ImageオブジェクトのGraphicsオブジェクトを作成する
                    Graphics graphics1 = pic_avater.CreateGraphics();
                    Graphics graphics2 = pic_color_lr.CreateGraphics();

                    //PictureBoxのImageプロパティに設定する
                    pic_avater.Image = bmp_avater1;
                    pic_color_lr.Image = bmp_avater2;

                    //描画
                    graphics1.DrawImage(pic_avater.Image, pic_avater.Location);
                    graphics2.DrawImage(pic_color_lr.Image, pic_color_lr.Location);
                }

                connection.Close();
            }
        }
    }
}
