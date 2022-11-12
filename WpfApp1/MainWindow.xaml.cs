using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
<<<<<<< Updated upstream
using Microsoft.Win32;
=======
using Microsoft.Win32;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
using System.Security.Cryptography;
using ClosedXML.Excel;
//here we go again
namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        //MediaPlayer highest_in_the_room
        private MediaPlayer mediaPlayer = new MediaPlayer();
        string list_string;
        ApplicationContext db;

        public MainWindow()
<<<<<<< Updated upstream
        {
=======
        {
            //_3d_model powned = new _3d_model();
            //powned.Owner = this;

            
            
            

<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            db = new ApplicationContext();
            List<user> users = db.users.ToList();
            list_string = " ";
            foreach (user user in users)
            {
                list_string += "login: " + user.Login + " | "; //+ " Email: " + user.Email + " Password: " + user.Password;
            }
            //List<input_paint> inputs_paint = db.inputs_paint.ToList();

            InitializeComponent();

            

            register_grid.Visibility = Visibility.Hidden;
            grid_menu.Visibility = Visibility.Hidden;
            grid_paint_calc.Visibility = Visibility.Hidden;
            paint_options_grid.Visibility = Visibility.Hidden;
            space_grid.Visibility = Visibility.Hidden;
            height2_grid.Visibility = Visibility.Hidden;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
            height3_grid.Visibility = Visibility.Hidden;
            height4_grid.Visibility = Visibility.Hidden;

>>>>>>> Stashed changes
=======
            height3_grid.Visibility = Visibility.Hidden;
            height4_grid.Visibility = Visibility.Hidden;

>>>>>>> Stashed changes
=======
            height3_grid.Visibility = Visibility.Hidden;
            height4_grid.Visibility = Visibility.Hidden;

>>>>>>> Stashed changes
=======
            height3_grid.Visibility = Visibility.Hidden;
            height4_grid.Visibility = Visibility.Hidden;

>>>>>>> Stashed changes
            history_grid.Visibility = Visibility.Hidden;
            menu2_grid.Visibility = Visibility.Hidden;
            profile_grid1.Visibility = Visibility.Hidden;
            admin_grid.Visibility = Visibility.Hidden;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        }


=======
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            
            wallpapers_grid.Visibility = Visibility.Hidden;
            plaster_grid.Visibility = Visibility.Hidden;
            grunt_grid.Visibility = Visibility.Hidden;
            ground_coat_grid.Visibility = Visibility.Hidden;
            paint_grid.Visibility = Visibility.Hidden;

            do_calculation.IsEnabled = false;
            add_room_button.IsEnabled = false;
        }


>>>>>>> Stashed changes
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        Boolean language = true; // false - Russian, true - English
        byte measure_system = 1; // 1 - meters, 2 - centimetrs, 3 - inches
        byte user_type = 0;
        string measure_ln = "м";
        string centim_ln, perimetr_ln, metr_ln, inch_ln, wallarea_ln, height_ln, width_ln, lenght_ln, groundarea_ln;
        string metr_ru = "м";
        string metr_en = "m";
        string centim_ru = "см";
        string centim_en = "cm";
        string inch_ru = "дюйм";
        string inch_en = "inch";
        string width_ru = "Ширина";
        string width_en = "width";
        string lenght_ru = "Длина";
        string lenght_en = "Lenght";
        string height_ru = "Высота";
        string height_en = "Height";
        string wallarea_ru = "Площадь";
        string wallarea_en = "Square area";
        string perimetr_ru = "Периметр";
        string perimetr_en = "Perimetr";
        string groundarea_ru = "Площадь пола/потолка";
        string groundarea_en = "Ground/ceiling area";
        float wallarea = 0;
        float ceiling_area = 0;
        float ceiling_perimetr = 0;
        float perimetr = 0;
        float groundarea = 0;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        float height1, width1, length1, height2, width2, length2, space_width, space_height, space_square, all_space_square, all_height_lenght;
        float an1, an2, an3, an4;
        int space_id = 0;
        int current_user_id;
        string profile_user_mail = "NOTHING";
        string profile_user_login = "NOTHING";

        // start check value func
        static string only_numbers(string number)
        {
            string number_str = number.ToString();
            float number_float;

            NumberStyles style;
            CultureInfo culture;
            style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint;
            culture = CultureInfo.CreateSpecificCulture("ru-RU");

            if (float.TryParse(number_str, style, culture, out number_float))
            {
                return number_float.ToString();
            }
            else
            {
                return "false";
            }
        }
        static float check_value(string value_str){
            float value_float;
            if (only_numbers(value_str) != "false")
            {
                value_float = float.Parse(only_numbers(value_str));
                return value_float;
            }
            else
            {
                string value_string_2 = value_str.Replace(".", ",");
                if (float.TryParse(value_string_2, out value_float))
                {
                    value_float = float.Parse(value_str.Replace(".", ","));
                    return value_float;
                }
                else
                {
                    return -1;
                }
            }
        }
        // end check value func

        int room_number_export = 1;
        public void calculation()
        {
            height1 = check_value(height_textbox.Text);
            height2 = check_value(height2_textbox.Text);
            width1 = check_value(width_textbox.Text);
            length1 = check_value(length_textbox.Text);
            if (height1 > 0 && width1 > 0 && length1 > 0)
            {
                TimeZone curTimeZone = TimeZone.CurrentTimeZone;
                TimeSpan curUTC = curTimeZone.GetUtcOffset(DateTime.Now);
                string date = DateTime.Now.ToString();
                string utc_type = curUTC.ToString();
                string date_of_calc = date + ", UTC+" + utc_type;
                input_paints input = new input_paints();
                output_paints output = new output_paints();
                switch (selected_type_of_calc)
                {

                    case 1:


                        wallarea = (width1 * height1 + length1 * height1) * 2 - all_space_square;
                        perimetr = (width1 + length1) * 2;
                        groundarea = width1 * length1;

                        all_height_lenght = height1 * 4;
                        an1 = 90;
                        an2 = 90;
                        an3 = 90;
                        an4 = 90;
                        //space_grid.Margin = new Thickness(0, 300, 0, 0);
                        //textblock_paint_result.Margin = new Thickness(0, 115, 0, 0);
                        textblock_paint_result.Text = "Площадь стен: " + wallarea.ToString() + " Периметр пола: " + perimetr.ToString() + " Площадь потолка: " + groundarea.ToString();




                        /* user user = new user(register_user_login, register_user_email, register_user_pass1, "false");

                         db.users.Add(user);
                         db.SaveChanges();*/

                        break;
                    case 2:
                        height2 = check_value(height2_textbox.Text);
                        if (height2 > 0 && height1 > 0)
                        {
                            groundarea = width1 * length1;
                            perimetr = (width1 + length1) * 2;

                            if (height1 > height2)
                            {


                                wallarea = (width1 * (height1 - height2)) + (height2 * length1) + (height1 * length1) + (width1 * height2 * 2) - all_space_square;
                                ceiling_area = (float)Math.Sqrt((height1 - height2) * (height1 - height2) + width1 * width1) * length1;
                                ceiling_perimetr = (float)Math.Sqrt((height1 - height2) * (height1 - height2) + width1 * width1) * 2 + length1 * 2;
                            }
                            else if (height1 < height2)
                            {
                                wallarea = (width1 * (height2 - height1)) + (height2 * length1) + (height1 * length1) + (width1 * height1 * 2) - all_space_square;
                                ceiling_area = (float)Math.Sqrt((height2 - height1) * (height2 - height1) + width1 * width1) * length1;
                                ceiling_perimetr = (float)Math.Sqrt((height2 - height1) * (height2 - height1) + width1 * width1) * 2 + length1 * 2;
                            }
                            else
                            {
                                wallarea = (width1 * height1 + length1 * height1) * 2 - all_space_square;
                                ceiling_area = groundarea;
                                ceiling_perimetr = perimetr;
                            }
                            groundarea = width1 * length1;
                            textblock_paint_result.Text = "Площадь стен: " + wallarea.ToString() + " Периметр пола: " + perimetr.ToString() + " Площадь потолка: " + ceiling_area.ToString();
                            all_height_lenght = (height1 + height2) * 2;

                            //space_grid.Margin = new Thickness(0, 345, 0, 0);
                            //textblock_paint_result.Margin = new Thickness(0, 160, 0, 0);
                        }
                        else
                        {
                            warning_number_window();
                        }
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                }
                input = new input_paints(current_user_id.ToString(), selected_type_of_calc.ToString(), an1.ToString(), an2.ToString(), an3.ToString(), an4.ToString(), width1.ToString(), width1.ToString(), length1.ToString(), length1.ToString(), height1.ToString(), height1.ToString(), height1.ToString(), height1.ToString(), all_space_square.ToString(), date_of_calc, room_number_export.ToString());
                db.input_paint.Add(input);

                output = new output_paints(current_user_id.ToString(), wallarea.ToString(), perimetr.ToString(), groundarea.ToString(), groundarea.ToString(), perimetr.ToString(), all_space_square.ToString(), all_height_lenght.ToString(), date_of_calc);
                db.output_paint.Add(output);
                db.SaveChanges();


                //current_user_id = 0;

            }
            else
            {
                warning_number_window();
            }
        }
        // button "give result" was tapped
        private void Button_Click_1(object sender, RoutedEventArgs e)
=======
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        public float height1, height2, height3, height4, width1, length1, width2, length2, space_width, space_height, space_square, all_space_square, all_height_lenght;
        public float an1, an2, an3, an4;

        float wallpapers_width, wallpapers_length_m, wallpapers_amount, wallpapers_circle;
        float plaster_volume_m, plaster_kg, plaster_amount;
        float grunt_volume_m, grunt_kg, grunt_amount;
        float ground_coat_volume_m, ground_coat_volume_kg, ground_coat_amout;
        float paint_volume_m, paint_volume_kg, paint_amount;
        
        float out_plaster_volume_m, out_plaster_kg;
        float out_grunt_volume_m, out_grunt_kg;
        float out_ground_coat_volume_m, out_ground_coat_volume_kg;
        float out_paint_volume_m, out_paint_volume_kg;

        int plaster_thick, grunt_layers, ground_coat_thick, paint_layers;
        int space_id = 0;
        int current_user_id;
        string profile_user_mail = "NOTHING";
        string profile_user_login = "NOTHING";

        int spaces_top = 0;
        int wallpapers_top = 0;
        int plaster_top = 0;
        int grunt_top = 0;
        int ground_coat_top = 0;
        int paint_top = 0;

        // start check value func
        static string only_numbers(string number)
        {
            string number_str = number.ToString();
            float number_float;

            NumberStyles style;
            CultureInfo culture;
            style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint;
            culture = CultureInfo.CreateSpecificCulture("ru-RU");

            if (float.TryParse(number_str, style, culture, out number_float))
            {
                return number_float.ToString();
            }
            else
            {
                return "false";
            }
        }
        static float check_value(string value_str){
            float value_float;
            if (only_numbers(value_str) != "false")
            {
                value_float = float.Parse(only_numbers(value_str));
                if (value_float < 1000)
                {
                    return value_float;
                } else
                {
                    return -1;
                }
            }
            else
            {
                string value_string_2 = value_str.Replace(".", ",");
                if (float.TryParse(value_string_2, out value_float))
                {
                    value_float = float.Parse(value_str.Replace(".", ","));
                    if (value_float < 1000)
                    {
                        return value_float;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return -1;
                }
            }
        }
        // end check value func

        int room_number_export = 1;
        public void calculation()
        {
            /*
            wallpapers_width, 
                wallpapers_length_m, 
                wallpapers_amount, 
            wallpapers_circle;
            plaster_thick, 
                plaster_volume_m, 
                plaster_kg;
            grunt_layers, 
                grunt_volume_m, 
                grunt_kg;
            ground_coat_thick, 
                ground_coat_volume_m, 
                ground_coat_volume_kg;
            paint_layers, 
                paint_volume_m;*/
            height1 = check_value(height_textbox.Text);
            //height2 = check_value(height2_textbox.Text);
            width1 = check_value(width_textbox.Text);
            length1 = check_value(length_textbox.Text);
            
            if (height1 > 0 && width1 > 0 && length1 > 0)
            {
                TimeZone curTimeZone = TimeZone.CurrentTimeZone;
                TimeSpan curUTC = curTimeZone.GetUtcOffset(DateTime.Now);
                string date = DateTime.Now.ToString();
                string utc_type = curUTC.ToString();
                string date_of_calc = date + ", UTC+" + utc_type;
                input_paints input = new input_paints();
                output_paints output = new output_paints();
                materials material = new materials();
                switch (selected_type_of_calc)
                {

                    case 1:


                        wallarea = (width1 * height1 + length1 * height1) * 2 - all_space_square;
                        perimetr = (width1 + length1) * 2;
                        groundarea = width1 * length1;

                        all_height_lenght = height1 * 4;
                        an1 = 90;
                        an2 = 90;
                        an3 = 90;
                        an4 = 90;
                        
                       textblock_paint_result.Text = "Комната №"+room_number_export+" Площадь стен: " + wallarea.ToString() + " Периметр пола: " + perimetr.ToString() + " Площадь потолка: " + groundarea.ToString();
                        //grid_paint_calc.Content = "Комната №" + room_number_export + " Площадь стен: " + wallarea.ToString() + " Периметр пола: " + perimetr.ToString() + " Площадь потолка: " + groundarea.ToString();



                        /* user user = new user(register_user_login, register_user_email, register_user_pass1, "false");

                         db.users.Add(user);
                         db.SaveChanges();*/

                        break;
                    case 2:
                        height2 = check_value(height2_textbox.Text);
                        if (height2 > 0 && height1 > 0)
                        {
                            groundarea = width1 * length1;
                            perimetr = (width1 + length1) * 2;

                            if (height1 > height2)
                            {


                                wallarea = (width1 * (height1 - height2)) + (height2 * length1) + (height1 * length1) + (width1 * height2 * 2) - all_space_square;
                                ceiling_area = (float)Math.Sqrt((height1 - height2) * (height1 - height2) + width1 * width1) * length1;
                                ceiling_perimetr = (float)Math.Sqrt((height1 - height2) * (height1 - height2) + width1 * width1) * 2 + length1 * 2;
                            }
                            else if (height1 < height2)
                            {
                                wallarea = (width1 * (height2 - height1)) + (height2 * length1) + (height1 * length1) + (width1 * height1 * 2) - all_space_square;
                                ceiling_area = (float)Math.Sqrt((height2 - height1) * (height2 - height1) + width1 * width1) * length1;
                                ceiling_perimetr = (float)Math.Sqrt((height2 - height1) * (height2 - height1) + width1 * width1) * 2 + length1 * 2;
                            }
                            else
                            {
                                wallarea = (width1 * height1 + length1 * height1) * 2 - all_space_square;
                                ceiling_area = groundarea;
                                ceiling_perimetr = perimetr;
                            }
                            groundarea = width1 * length1;
                            textblock_paint_result.Text = "Комната №" + room_number_export + "Площадь стен: " + wallarea.ToString() + " Периметр пола: " + perimetr.ToString() + " Площадь потолка: " + ceiling_area.ToString();
                            //grid_paint_calc.Content = "Комната №" + room_number_export + " Площадь стен: " + wallarea.ToString() + " Периметр пола: " + perimetr.ToString() + " Площадь потолка: " + groundarea.ToString();
                            all_height_lenght = (height1 + height2) * 2;

                            //space_grid.Margin = new Thickness(0, 345, 0, 0);
                            //textblock_paint_result.Margin = new Thickness(0, 160, 0, 0);
                        }
                        else
                        {
                            warning_number_window();
                        }
                        break;
                    case 3:
                        height1 = check_value(height_textbox.Text);
                        height2 = check_value(height2_textbox.Text);
                        height3 = check_value(height3_textbox.Text);
                        height4 = check_value(height4_textbox.Text);
                        if (height1 > 0 && height2 > 0 && height3 > 0 && height4 > 0)
                        {
                            groundarea = width1 * length1;
                            //perimetr = (width1 + length1) * 2;
                            wallarea = 0;
                            ceiling_perimetr = 0;
                            ceiling_area = 0;
                            float a1, b2, c3, d4;
                            float diagonal;
                            diagonal = (float)Math.Sqrt(Math.Pow(width1, 2) + Math.Pow(length1, 2));

                            // 111
                            if (height1 > height2)
                            {
                                
                                wallarea += (length1*height2) + ((height1-height2) * length1)/2;
                                a1 = (float)Math.Sqrt(Math.Pow(height1 - height2, 2) + Math.Pow(length1, 2));
                                ceiling_perimetr += a1;
                            }
                            else if (height1 < height2)
                            {
                                wallarea += (length1 * height1) + ((height2-height1) * length1) / 2;
                                a1 = (float)Math.Sqrt(Math.Pow(height1 - height2, 2) + Math.Pow(length1, 2));
                                ceiling_perimetr += a1;
                            }
                            else
                            {
                                wallarea += length1 * height1;
                                ceiling_perimetr += length1;
                                a1 = length1;
                            }

                            // 222
                            if (height2 > height3)
                            {
                                wallarea += (length1 * height3) + ((height2-height3) * length1) / 2;
                                b2 = (float)Math.Sqrt(Math.Pow(height2 - height3, 2) + Math.Pow(width1, 2));
                                ceiling_perimetr += b2;
                            }
                            else if (height2 < height3)
                            {
                                wallarea += (length1 * height2) + ((height3-height2) * length1) / 2;
                                b2 = (float)Math.Sqrt(Math.Pow(height3 - height2, 2) + Math.Pow(width1, 2));
                                ceiling_perimetr += b2;
                            }
                            else
                            {
                                wallarea += length1 * height2;
                                ceiling_perimetr += length1;
                                b2 = length1;
                            }

                            // 333
                            if (height3 > height4)
                            {
                                wallarea += (length1 * height4) + ((height3-height4) * length1) / 2;
                                c3 = (float)Math.Sqrt(Math.Pow(height3 - height4, 2) + Math.Pow(length1, 2));
                                ceiling_perimetr += c3;
                            }
                            else if (height3 < height4)
                            {
                                wallarea += (length1 * height3) + ((height4-height3) * length1) / 2;
                                c3 = (float)Math.Sqrt(Math.Pow(height4 - height3, 2) + Math.Pow(length1, 2));
                                ceiling_perimetr += c3;
                            }
                            else
                            {
                                wallarea += length1 * height3;
                                ceiling_perimetr += length1;
                                c3 = length1;
                            }

                            // 444
                            if (height4 > height1)
                            {
                                wallarea += (length1 * height1) + ((height4-height1) * length1) / 2;
                                d4 = (float)Math.Sqrt(Math.Pow(height4 - height1, 2) + Math.Pow(width1, 2));
                                ceiling_perimetr += a1;
                            }
                            else if (height4 < height1)
                            {
                                wallarea += (length1 * height4) + ((height1-height4) * length1) / 2;
                                d4 = (float)Math.Sqrt(Math.Pow(height1 - height4, 2) + Math.Pow(width1, 2));
                                ceiling_perimetr += a1;
                            }
                            else
                            {
                                wallarea += length1 * height4;
                                ceiling_perimetr += length1;
                                d4 = length1;
                            }
                            wallarea -= all_space_square;
                            groundarea = width1 * length1;
                            perimetr = width1 * 2 + length1 * 2;
                            float polu_p1 = (a1 + diagonal + d4) / 2;
                            float polu_p2 = (c3 + diagonal + b2) / 2;
                            ceiling_area = 0;
                            ceiling_area += (float)Math.Sqrt(polu_p1 * (polu_p1 - a1) * (polu_p1 - d4) * (polu_p1 - diagonal));
                            ceiling_area += (float)Math.Sqrt(polu_p2*(polu_p2 - b2)*(polu_p2 - c3)*(polu_p2 - diagonal));
                            textblock_paint_result.Text = "Комната №" + room_number_export + "Площадь стен: " + wallarea.ToString() + " Периметр пола: " + perimetr.ToString() + " Площадь потолка: " + ceiling_area.ToString();
                        } else
                        {
                            warning_number_window();
                        }
                            break;
                    case 4:

                        break;
                }
                int a;
                if (check_wall)
                {
                    wallpapers_width = check_value(wallpaper_width_textbox.Text); // ширина обоев
                    wallpapers_circle = check_value(wallpaper_circle_textbox.Text); // длина рулона
                    if (wallpapers_width * wallpapers_circle > 0)
                    {
                       wallpapers_length_m = wallarea / wallpapers_width;
                       wallpapers_amount = wallpapers_length_m / wallpapers_circle;
                    } else
                    {
                        warning_number_window();
                        wallpapers_length_m = 0;
                        wallpapers_amount = 0;
                    }
                } else
                {
                    wallpapers_width = 0;
                    wallpapers_circle = 0;
                    wallpapers_length_m = 0;
                    wallpapers_amount = 0;
                }
                if (check_plaster)
                {
                    plaster_thick = int.Parse(plaster_thick_textbox.Text);
                    plaster_volume_m = check_value(plaster_mesh_m_textbox.Text);
                    plaster_kg = check_value(plaster_mesh_kg_textbox.Text);
                    if (plaster_volume_m > 0 && int.TryParse(plaster_thick.ToString(), out a))
                    {
                        out_plaster_volume_m = wallarea * plaster_thick;
                        plaster_amount = out_plaster_volume_m / plaster_volume_m;
                        
                        //wallarea
                        if (plaster_kg > 0)
                        {
                            out_plaster_kg = plaster_amount * plaster_kg;
                        } else
                        {
                            out_plaster_kg = 0;
                            //plaster_volume_m
                        }
                    } else
                    {
                        warning_number_window();
                    }
                    /*MessageBox.Show("Шпаклевка INPUT: Одной емкости с шпаклевкой хватит на " 
                        + plaster_volume_m + "м^2" + ", вес одной емкости = "+ plaster_kg + 
                        " кг , кол-во слоёв = " + plaster_thick + " OUTPUT: Необходимое кол-во емкостей = "+ plaster_amount + " шт, вес всех емкостей = " + out_plaster_kg + "кг, общий объем = " + out_plaster_volume_m + " м^2");
                */} else
                {
                    plaster_thick = 0;
                    plaster_kg = 0;
                    plaster_volume_m = 0;
                    out_plaster_volume_m = 0;
                    out_plaster_kg = 0;
                    plaster_amount = 0;
                }
                if (check_grunt)
                {
                   // grunt_layers = check_value(grunt_thick_textbox.Text);
                    grunt_volume_m = check_value(grunt_mesh_m_textbox.Text);
                    grunt_kg = check_value(grunt_mesh_kg_textbox.Text);

                    grunt_layers = int.Parse(grunt_thick_textbox.Text);
                    grunt_volume_m = check_value(grunt_mesh_m_textbox.Text);
                    grunt_kg = check_value(grunt_mesh_kg_textbox.Text);
                    if (grunt_volume_m > 0 && int.TryParse(grunt_layers.ToString(), out a))
                    {
                        out_grunt_volume_m = wallarea * grunt_layers;
                        grunt_amount = out_grunt_volume_m / grunt_volume_m;

                        //wallarea
                        if (grunt_kg > 0)
                        {
                            out_grunt_kg = grunt_amount * grunt_kg;
                        }
                        else
                        {
                            out_grunt_kg = 0;
                            //grunt_volume_m
                        }
                    }
                    else
                    {
                        warning_number_window();
                    }

                } else
                {
                    grunt_layers = 0;
                    grunt_kg = 0;
                    grunt_volume_m = 0;
                    out_grunt_volume_m = 0;
                    out_grunt_kg = 0;
                    grunt_amount = 0;
                }
                if (check_ground_coat)
                {
                   // ground_coat_thick = check_value(ground_coat_thick_textbox.Text);
                    ground_coat_volume_m = check_value(ground_coat_mesh_m_textbox.Text);
                    ground_coat_volume_kg = check_value(ground_coat_mesh_kg_textbox.Text);

                    ground_coat_thick = int.Parse(ground_coat_thick_textbox.Text);
                    ground_coat_volume_m = check_value(ground_coat_mesh_m_textbox.Text);
                    ground_coat_volume_kg = check_value(ground_coat_mesh_kg_textbox.Text);
                    if (ground_coat_volume_m > 0 && int.TryParse(ground_coat_thick.ToString(), out a))
                    {
                        out_ground_coat_volume_m = wallarea * ground_coat_thick;
                        ground_coat_amout = out_ground_coat_volume_m / ground_coat_volume_m;

                        //wallarea
                        if (ground_coat_volume_kg > 0)
                        {
                            out_ground_coat_volume_kg = ground_coat_amout * ground_coat_volume_kg;
                        }
                        else
                        {
                            out_ground_coat_volume_kg = 0;
                            //plaster_volume_m
                        }
                    }
                    else
                    {
                        warning_number_window();
                    }
                } else
                {
                    ground_coat_thick = 0;
                    ground_coat_volume_kg = 0;
                    ground_coat_volume_m = 0;
                    out_ground_coat_volume_m = 0;
                    out_ground_coat_volume_kg = 0;
                    ground_coat_amout = 0;
                }
                if (check_paint)
                {
                   // paint_layers = check_value(paint_thick_textbox.Text);
                    paint_volume_m = check_value(paint_mesh_m_textbox.Text);
                    paint_volume_kg = check_value(paint_mesh_kg_textbox.Text);

                    paint_layers = int.Parse(paint_thick_textbox.Text);
                    paint_volume_m = check_value(paint_mesh_m_textbox.Text);
                    paint_volume_kg = check_value(paint_mesh_kg_textbox.Text);
                    if (paint_volume_m > 0 && int.TryParse(paint_layers.ToString(), out a))
                    {
                        out_paint_volume_m = wallarea * paint_layers;
                        paint_amount = out_paint_volume_m / paint_volume_m;

                        //wallarea
                        if (paint_volume_kg > 0)
                        {
                            out_paint_volume_kg = paint_amount * paint_volume_kg;
                        }
                        else
                        {
                            out_paint_volume_kg = 0;
                            //plaster_volume_m
                        }
                    }
                    else
                    {
                        warning_number_window();
                    }
                } else
                {
                    paint_layers = 0;
                    paint_volume_kg = 0;
                    paint_volume_m = 0;
                    out_paint_volume_m = 0;
                    out_paint_volume_kg = 0;
                    paint_amount = 0;
                }
                try
                {
                    input = new input_paints(current_user_id.ToString(), selected_type_of_calc.ToString(), an1.ToString(), an2.ToString(), an3.ToString(), an4.ToString(), width1.ToString(), width1.ToString(), length1.ToString(), length1.ToString(), height1.ToString(), height1.ToString(), height1.ToString(), height1.ToString(), all_space_square.ToString(), date_of_calc, room_number_export.ToString());
                    db.input_paint.Add(input);
                    material = new materials(current_user_id.ToString(), wallpapers_width.ToString(), wallpapers_circle.ToString(), wallpapers_length_m.ToString(), wallpapers_amount.ToString(), plaster_thick.ToString(), plaster_kg.ToString(), plaster_volume_m.ToString(), out_plaster_volume_m.ToString(), out_plaster_kg.ToString(), plaster_amount.ToString(), grunt_layers.ToString(), grunt_kg.ToString(), grunt_volume_m.ToString(), out_grunt_volume_m.ToString(), out_grunt_kg.ToString(), grunt_amount.ToString(), ground_coat_thick.ToString(), ground_coat_volume_kg.ToString(), ground_coat_volume_m.ToString(), out_ground_coat_volume_m.ToString(), out_ground_coat_volume_kg.ToString(), ground_coat_amout.ToString(), paint_layers.ToString(), paint_volume_kg.ToString(), paint_volume_m.ToString(), out_paint_volume_m.ToString(), out_paint_volume_kg.ToString(), paint_amount.ToString());
                    db.material.Add(material);
                    output = new output_paints(current_user_id.ToString(), wallarea.ToString(), perimetr.ToString(), groundarea.ToString(), groundarea.ToString(), perimetr.ToString(), all_space_square.ToString(), all_height_lenght.ToString(), date_of_calc);
                    db.output_paint.Add(output);
                    db.SaveChanges();
                } catch
                {
                    MessageBox.Show("Ошибка записи в бд");
               }
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream

                var md5 = MD5.Create();
                string pass_md5 = "adminus";
=======
>>>>>>> Stashed changes

                var md5 = MD5.Create();
                string pass_md5 = "adminus";

<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
=======

                var md5 = MD5.Create();
                string pass_md5 = "adminus";


>>>>>>> Stashed changes
=======

                var md5 = MD5.Create();
                string pass_md5 = "adminus";


>>>>>>> Stashed changes
                md5 = MD5.Create();
                pass_md5 = Convert.ToBase64String(md5.ComputeHash(Encoding.UTF8.GetBytes(pass_md5)));
                //height_textbox.Text = pass_md5;
                //MessageBox.Show(pass_md5);
                //current_user_id = 0;

            }
            else
            {
                warning_number_window();
            }
        }
        // button "give result" was tapped
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            calculation();
            first_room = true;
        }
        static void warning_number_window()
>>>>>>> Stashed changes
        {
            calculation();
        }
        static void warning_number_window()
        {
            MessageBox.Show("Не правильно введено число");
        }
        
        //language button
        private void Button_Click_2(object sender, RoutedEventArgs e) 
        {
            language = !language;
            if (language)
            {
                simple_room.Text = "Обычная комната";
                centim_ln = centim_ru;
                inch_ln = inch_ru;
                metr_ln = metr_ru;
                height_ln = height_ru;
                width_ln = width_ru;
                wallarea_ln = wallarea_ru;
                perimetr_ln = perimetr_ru;
                groundarea_ln = groundarea_ru;
                lenght_ln = lenght_ru;
                metr_ln = metr_ru;
                centim_ln = centim_ru;
                inch_ln = inch_ru;
                language_bt.Content = "English";
                switch (measure_system)
                {
                    case 1:
                        measure_bt.Content = "Метры";
                        break;
                    case 2:
                        measure_bt.Content = "Сантиметры";
                        break;
                    case 3:
                        measure_bt.Content = "Дюймы";
                        break;
                }
            }
            else
            {
                language_bt.Content = "Русский";
                simple_room.Text = "Simple room";
                centim_ln = centim_en;
                inch_ln = inch_en;
                metr_ln = metr_en;
                height_ln = height_en;
                width_ln = width_en;
                wallarea_ln = wallarea_en;
                perimetr_ln = perimetr_en;
                groundarea_ln = groundarea_en;
                lenght_ln = lenght_en;
                switch (measure_system)
                {
                    case 1:
                        measure_bt.Content = "Meters";
                        break;
                    case 2:
                        measure_bt.Content = "Centimetrs";
                        break;
                    case 3:
                        measure_bt.Content = "Inches";
                        break;
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) // measure system button
        {
            if (measure_system < 3) measure_system += 1; else measure_system = 1;
            switch (measure_system)
            {
                case 1:
                    wallarea = wallarea * 254 / 10000;
                    perimetr = perimetr * 254 / 10000;
                    groundarea = groundarea * 254 / 10000;
                    if (language)
                    {
                        measure_bt.Content = "Метры";
                        measure_ln = metr_ru;
                    }
                    else
                    {
                        measure_bt.Content = "Meters";
                        measure_ln = metr_en;
                    }

                    break;
                case 2:
                    wallarea = wallarea * 100;
                    perimetr = perimetr * 100;
                    groundarea = groundarea * 100; //  5/2,55 = 2 => 5*100/255 = 2
                    if (language)
                    {
                        measure_bt.Content = "Сантиметры";
                        measure_ln = centim_ru;
                    }
                    else
                    {
                        measure_bt.Content = "Centimetrs";
                        measure_ln = centim_en;
                    }

                    break;
                case 3:
                    wallarea = wallarea * 100 / 254;
                    perimetr = perimetr * 100 / 254;
                    groundarea = groundarea * 100 / 254;
                    if (language)
                    {
                        measure_bt.Content = "Дюймы";
                        measure_ln = inch_ru;
                    }
                    else
                    {
                         measure_bt.Content = "Inches";
                        measure_ln = inch_en;
                    }

                    break;
<<<<<<< Updated upstream
            }

        }

        Boolean grid_paint1 = true;

        public object RootLayout { get; private set; }
        //paint calc button
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //if (grid_paint1)
           // {
                //grid_paint_calc.Visibility = Visibility.Visible;
                //paint_options_grid.Visibility = Visibility.Visible;
                //grid_paint1 = !grid_paint1;
                //paint_calcs_btn.Visibility = Visibility.Hidden;
                hide_menu2(1);
                hide_paint_calc(0);
                
            /*}
            else
            {
                //grid_paint_calc.Visibility = Visibility.Hidden;
                //paint_options_grid.Visibility = Visibility.Hidden;
                //space_grid.Visibility = Visibility.Hidden;
                hide_menu2(0);
                hide_paint_calc(1);
                grid_paint1 = !grid_paint1;
            }*/
        }
        //Кнопка истории расчётов
        public class MyItem
        {
            public int id_calc { get; set; }

            public string date_calc { get; set; }
            public string type_calc { get; set; }
            public string square_calc { get; set; }
            public string square2_calc { get; set; }

        }
        public class MyItem2
        {
            public int user_id { get; set; }

            public string user_login { get; set; }
            public string user_mail { get; set; }
            public string user_pass { get; set; }
            public string user_admin { get; set; }

        }
        /*private void Button_delete_Click(object sender, RoutedEventArgs e)
        {
            //Button button = sender as Button;
            //Game game = button.DataContext as Game;
            //int id = game.ID;
            //int inex1 = sender.SelectedIndex
            int list_index = calcs_out_listview.SelectedIndex;
            MessageBox.Show("удалить запись номер "+ list_index + " ?");
        }*/
        private void profile_btn_Click(object sender, RoutedEventArgs e)
        {
            //history_listbox
            hide_menu2(1);
            hide_history_calc(0);
            calcs_history_update();
        }
        public void users_list_update()
        {
            List<user> users = db.users.ToList();

            var md5 = MD5.Create();
            int admin_count = 0;

            users_listview.Items.Clear();
            foreach (user user in users)
            {
                if (user.Admin_status != "true")
                {
                    int list_user_id = user.id;
                    string list_user_login = user.Login, list_user_mail = user.Email, list_user_admin = user.Admin_status;
                    string list_user_pass = user.Password;
                    list_user_pass = Convert.ToBase64String(md5.ComputeHash(Encoding.UTF8.GetBytes(list_user_pass)));
                    users_listview.Items.Add(new MyItem2 { user_id = list_user_id, user_login = list_user_login, user_mail = list_user_mail, user_pass = list_user_pass, user_admin = list_user_admin });
                }
                else
                {
                    admin_count++;
                }
                
            }
            MessageBox.Show("Пользователей со статусом администратора = " + admin_count);
        }
        public void calcs_history_update()
        {
            List<input_paints> inputs;
            List<output_paints> outputs;
            if (user_type == 2)
            {
                inputs = db.input_paint.ToList();
                outputs = db.output_paint.ToList();
            } else
            {
                inputs = db.input_paint.Where(b => b.User_id == current_user_id.ToString()).ToList();
                outputs = db.output_paint.Where(b => b.User_id == current_user_id.ToString()).ToList();
            }
            calcs_out_listview.Items.Clear();
            foreach (input_paints input in inputs)
            {
                int cur_id = input.id;
                int out_id;
                string out_square = "0", out_square2 = "0";
                foreach (output_paints output in outputs)
                {
                    if (output.id == cur_id)
                    {
                        out_id = output.id;
                        out_square = output.Wall_square;
                        out_square2 = output.Ceiling_area;
                    }
                }
                calcs_out_listview.Items.Add(new MyItem { id_calc = input.id, date_calc = input.Date, type_calc = input.Calc_type, square_calc = out_square, square2_calc = out_square2 });
            }
        }
        private void calcs_out_listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //go to main menu button
        Boolean menu_btn = false;
        private void Main_menu_btn_Click(object sender, RoutedEventArgs e)
        {
            if (menu_btn)
            {
                hide_menu2(0);
                admin_grid.Visibility = Visibility.Hidden;
                hide_paint_calc(1);
                hide_profile(1);
                hide_history_calc(1);

                menu_btn = !menu_btn;
            } else
            {
                hide_menu2(0);
                admin_grid.Visibility = Visibility.Hidden;
                hide_paint_calc(1);
                hide_history_calc(1);
                hide_profile(1);

                menu_btn = !menu_btn;
            }
        }
        byte selected_type_of_calc;

        // delete calc button
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

            var a = Int32.TryParse(deleted_calcs_id_textbox.Text.ToString(), out int value_1);
            if (a)
            {
                int delete_id = Math.Abs(Int32.Parse(deleted_calcs_id_textbox.Text.ToString()));
                try
                {
                    var input_del = db.input_paint.FirstOrDefault(x => x.id == delete_id);
                    db.input_paint.Remove(input_del);
                    db.SaveChanges();
                    var output_del = db.output_paint.FirstOrDefault(x => x.id == delete_id);
                    db.output_paint.Remove(output_del);
                    db.SaveChanges();
                    calcs_history_update();
                }
                catch
                {

                }
            }
            else
            {
                warning_number_window();
            }
        }


        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            grid_menu.Visibility = Visibility.Visible;
            main_menu_grid.Visibility = Visibility.Hidden;
            history_button.IsEnabled = false;
            history_btn.IsEnabled = false;
            user_type = 3;

            login_textbox.Text = "";
            pass_textbox.Password = "";
            textblock_paint_result.Text = "Выберете \"Тип расчёта\"";
        }

        //when type of calc changed
        private void Paint_calcs_combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selected_type_of_calc = Convert.ToByte(paint_calcs_combobox.SelectedIndex + 1);
            //MessageBox.Show(selected_type_of_calc.ToString());
            //Thickness space_margin = space_grid.Margin;
            textblock_paint_result.Text = "Нажмите \"Рассчитать\"";
            switch (selected_type_of_calc)
            {
                case 1:
                    //space_grid.Margin = new Thickness(0, 300, 0, 0);
                    //textblock_paint_result.Margin = new Thickness(0, 115, 0, 0);
                    height2_grid.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    //space_grid.Margin = new Thickness(0, 345, 0, 0);
                    //textblock_paint_result.Margin = new Thickness(0, 160, 0, 0);
                    height2_grid.Visibility = Visibility.Visible;
                    break;
                case 3:
                    height2_grid.Visibility = Visibility.Visible;
                    break;
                case 4:

                    break;
            }
        }
        // add space button
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            space_width = check_value(space_width_textbox.Text);
            space_height = check_value(space_height_textbox.Text);
            if (space_height > 0 && space_width > 0)
            {
                space_id++;
                space_square = space_width * space_height;
                space_listbox.Items.Add("Проем №" + space_id + ", Ширина - " + space_width + ", Высота - " + space_height + ", Площадь - " + space_square + " - " + measure_ln + "\u00B2");
                all_space_square += space_square;
            } else
            {
                warning_number_window();
            }
        }


        private void Space_history_listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Account_info_btn_Click(object sender, RoutedEventArgs e)
        {
            hide_profile(0);
            hide_menu2(1);
            login_info_textbox.Text = profile_user_login;
            mail_info_textbox.Text = profile_user_mail;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void history_button_Click(object sender, RoutedEventArgs e)
        {
            admin_grid.Visibility = Visibility.Visible;
            hide_menu2(1);
            users_list_update();
        }

        private void delete_user_button_Click(object sender, RoutedEventArgs e)
        {
            var a = Int32.TryParse(deleted_user_id_textbox.Text.ToString(), out int value_1);
            if (a)
            {
                int delete_id = Math.Abs(Int32.Parse(deleted_user_id_textbox.Text.ToString()));
                user admin_stat = null;
                using (ApplicationContext db = new ApplicationContext())
                {
                    admin_stat = db.users.Where(b => b.id == delete_id).FirstOrDefault();
                }
                try
                {
                    if (admin_stat != null)
                    {

                        if (admin_stat.Admin_status != "true")
                        {
                            try
                            {
                                var input_del = db.users.FirstOrDefault(x => x.id == delete_id);
                                db.users.Remove(input_del);
                                db.SaveChanges();
                                users_list_update();
                            }
                            catch
                            {

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка");
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
            else
            {
                warning_number_window();
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            void Create(string filePath)
            {
                string calc_id, user_id, calc_type, an1, an2, an3, an4, w1, w2, l1, l2, h1, h2, h3, h4, space_square, date;
                string wall_square, ceiling_perimetr, ceiling_area, ground_area, ground_perimetr, height_length;
                List<input_paints> inputs;
                List<output_paints> outputs;
                if (user_type == 2)
                {
                    inputs = db.input_paint.ToList();
                    outputs = db.output_paint.ToList();
                }
                else
                {
                    inputs = db.input_paint.Where(b => b.User_id == current_user_id.ToString()).ToList();
                    outputs = db.output_paint.Where(b => b.User_id == current_user_id.ToString()).ToList();
                }

                string a_col = "A", b_col = "B", c_col = "C", d_col = "D", e_col = "E", f_col = "F", g_col = "G", h_col = "H";
                string i_col = "I", j_col = "J", k_col = "K", l_col = "L", m_col = "M", n_col = "N", o_col = "O", p_col = "P";
                string q_col = "Q", r_col = "R", s_col = "S", t_col = "T", u_col = "U", v_col = "V", w_col = "W", x_col = "X";
                int row_count = 2;

                var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add("Расчёты");
                ws.Cell("A1").Value = "Id Расчета";
                ws.Cell("B1").Value = "Id Пользователя";
                ws.Cell("C1").Value = "Тип расчёта";
                ws.Cell("D1").Value = "Угол №1";
                ws.Cell("E1").Value = "Угол №2";
                ws.Cell("F1").Value = "Угол №3";
                ws.Cell("G1").Value = "Угол №4";
                ws.Cell("H1").Value = "Ширнина №1";
                ws.Cell("I1").Value = "Ширнина №2";
                ws.Cell("J1").Value = "Длина №1";
                ws.Cell("K1").Value = "Длина №2";
                ws.Cell("L1").Value = "Высота №1";
                ws.Cell("M1").Value = "Высота №2";
                ws.Cell("N1").Value = "Высота №3";
                ws.Cell("O1").Value = "Высота №4";
                ws.Cell("P1").Value = "Площадь стен";
                ws.Cell("Q1").Value = "Периметр потолка";
                ws.Cell("R1").Value = "Площадь потолка";
                ws.Cell("S1").Value = "Площадь пола";
                ws.Cell("T1").Value = "Периметр пола";
                ws.Cell("U1").Value = "Площадь проемов";
                ws.Cell("V1").Value = "Общая высота всех углов";
                ws.Cell("W1").Value = "Дата";

                
                foreach (input_paints input in inputs)
                {
                    int cur_id = input.id;
                    calc_id = cur_id.ToString();
                    user_id = current_user_id.ToString();
                    calc_type = input.Calc_type;
                    an1 = input.An1;
                    an2 = input.An2;
                    an3 = input.An3;
                    an4 = input.An4;
                    w1 = input.W1;
                    w2 = input.W2;
                    l1 = input.L1;
                    l2 = input.L2;
                    h1 = input.H1;
                    h2 = input.H2;
                    h3 = input.H3;
                    h4 = input.H4;
                    space_square = input.Space_square;
                    date = input.Date;
                    int out_id;
                    string out_square = "0", out_square2 = "0";
                    foreach (output_paints output in outputs)
                    {
                        
                        if (output.id == cur_id)
                        {
                            wall_square = output.Wall_square;
                            ceiling_perimetr = output.Ceiling_perimetr;
                            ceiling_area = output.Ceiling_area;
                            ground_area = output.Ground_area;
                            ground_perimetr = output.Ground_perimetr;
                            height_length = output.Height_lenght;

                            a_col += row_count.ToString();
                            b_col += row_count.ToString();
                            c_col += row_count.ToString();
                            d_col += row_count.ToString();
                            e_col += row_count.ToString();
                            f_col += row_count.ToString();
                            g_col += row_count.ToString();
                            h_col += row_count.ToString();
                            i_col += row_count.ToString();
                            j_col += row_count.ToString();
                            k_col += row_count.ToString();
                            l_col += row_count.ToString();
                            m_col += row_count.ToString();
                            n_col += row_count.ToString();
                            o_col += row_count.ToString();
                            p_col += row_count.ToString();
                            q_col += row_count.ToString();
                            r_col += row_count.ToString();
                            s_col += row_count.ToString();
                            t_col += row_count.ToString();
                            u_col += row_count.ToString();
                            v_col += row_count.ToString();
                            w_col += row_count.ToString();
                            x_col += row_count.ToString();

                            ws.Cell(a_col).Value = cur_id;
                            ws.Cell(b_col).Value = current_user_id;
                            ws.Cell(c_col).Value = calc_type;
                            ws.Cell(d_col).Value = an1;
                            ws.Cell(e_col).Value = an2;
                            ws.Cell(f_col).Value = an3;
                            ws.Cell(g_col).Value = an4;
                            ws.Cell(h_col).Value = w1;
                            ws.Cell(i_col).Value = w2;
                            ws.Cell(j_col).Value = l1;
                            ws.Cell(k_col).Value = l2;
                            ws.Cell(l_col).Value = h1;
                            ws.Cell(m_col).Value = h2;
                            ws.Cell(n_col).Value = h3;
                            ws.Cell(o_col).Value = h4;
                            ws.Cell(p_col).Value = wall_square;
                            ws.Cell(q_col).Value = ceiling_perimetr;
                            ws.Cell(r_col).Value = ceiling_area;
                            ws.Cell(s_col).Value = ground_area;
                            ws.Cell(t_col).Value = ground_perimetr;
                            ws.Cell(u_col).Value = space_square;
                            ws.Cell(v_col).Value = height_length;
                            ws.Cell(w_col).Value = date;
                            a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                            i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                            q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                            row_count++;
                        }
                    }
                    wb.SaveAs(filePath);
                }
                // Creating a new workbook
                /*var wb = new XLWorkbook();

                //Adding a worksheet
                var ws = wb.Worksheets.Add("Contacts");

                //Adding text
                //Title
                ws.Cell("B2").Value = "Contacts";
                //First Names
                ws.Cell("B3").Value = "FName";
                ws.Cell("B4").Value = "John";
                ws.Cell("B5").Value = "Hank";
                ws.Cell("B6").Value = "Dagny";
                //Last Names
                ws.Cell("C3").Value = "LName";
                ws.Cell("C4").Value = "Galt";
                ws.Cell("C5").Value = "Rearden";
                ws.Cell("C6").Value = "Taggart";

                //Adding more data types
                //Is an outcast?
                ws.Cell("D3").Value = "Outcast";
                ws.Cell("D4").Value = true;
                ws.Cell("D5").Value = false;
                ws.Cell("D6").Value = false;
                //Date of Birth
                ws.Cell("E3").Value = "DOB";
                ws.Cell("E4").Value = new DateTime(1919, 1, 21);
                ws.Cell("E5").Value = new DateTime(1907, 3, 4);
                ws.Cell("E6").Value = new DateTime(1921, 12, 15);
                //Income
                ws.Cell("F3").Value = "Income";
                ws.Cell("F4").Value = 2000;
                ws.Cell("F5").Value = 40000;
                ws.Cell("F6").Value = 10000;

                //Defining ranges
                //From worksheet
                var rngTable = ws.Range("B2:F6");
                //From another range
                var rngDates = rngTable.Range("E4:E6");
                var rngNumbers = rngTable.Range("F4:F6");

                //Formatting dates and numbers
                //Using a OpenXML's predefined formats
                rngDates.Style.NumberFormat.NumberFormatId = 15;
                //Using a custom format
                rngNumbers.Style.NumberFormat.Format = "$ #,##0";

                //Formatting headers
                var rngHeaders = rngTable.Range("B3:F3");
                rngHeaders.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders.Style.Font.Bold = true;
                rngHeaders.Style.Fill.BackgroundColor = XLColor.Aqua;

                //Adding grid lines
                rngTable.Style.Border.BottomBorder = XLBorderStyleValues.Thin;

                //Format title cell
                rngTable.Cell(1, 1).Style.Font.Bold = true;
                rngTable.Cell(1, 1).Style.Fill.BackgroundColor = XLColor.CornflowerBlue;
                rngTable.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                //Merge title cells
                rngTable.Row(1).Merge(); // We could've also used: rngTable.Range("A1:E1").Merge()

                //Add thick borders
                rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thick;

                // You can also specify the border for each side with:
                // rngTable.FirstColumn().Style.Border.LeftBorder = XLBorderStyleValues.Thick;
                // rngTable.LastColumn().Style.Border.RightBorder = XLBorderStyleValues.Thick;
                // rngTable.FirstRow().Style.Border.TopBorder = XLBorderStyleValues.Thick;
                // rngTable.LastRow().Style.Border.BottomBorder = XLBorderStyleValues.Thick;

                // Adjust column widths to their content
                ws.Columns(2, 6).AdjustToContents();

                //Saving the workbook
                */
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Таблица Excel |*.xlsx";
            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    string path2 = saveFileDialog.FileName;
                    Create(path2);
                } catch
                {
                    
                }
            }    
        }

        private void add_room_button_Click(object sender, RoutedEventArgs e)
        {
            room_number_export++;
            calculation();
            do_calculation.IsEnabled = false;
        }

        private void finish_button_Click(object sender, RoutedEventArgs e)
        {

            room_number_export = 1;
            do_calculation.IsEnabled = true;
        }

        // clear all textboxes button
        private void Clear_button_Click(object sender, RoutedEventArgs e)
        {
            space_id = 0;
            space_square = 0;
            all_space_square = 0;
            space_listbox.Items.Clear();
            textblock_paint_result.Text = "";
            width_textbox.Text = "";
            height_textbox.Text = "";
            length_textbox.Text = "";
            height2_textbox.Text = "";
            space_height_textbox.Text = "";
            space_width_textbox.Text = "";

        }
        // checkbox spaces in true position
        Boolean space_check_value;
        private void Spaces_check_Checked(object sender, RoutedEventArgs e)
        {
            space_grid.Visibility = Visibility.Visible;
            space_check_value = true;
        }
        // checkbox spaces in false position
        private void Spaces_check_Unchecked(object sender, RoutedEventArgs e)
        {
            space_grid.Visibility = Visibility.Hidden;
            space_id = 0;
            space_square = 0;
            all_space_square = 0;
            space_listbox.Items.Clear();
            space_height_textbox.Text = "0";
            space_width_textbox.Text = "0";
            space_check_value = false;
        }
        // registration form button
        private void Register_acc_btn_Click(object sender, RoutedEventArgs e)
        {
            register_grid.Visibility = Visibility.Visible;
            main_menu_grid.Visibility = Visibility.Hidden;
        }
        //registration button for check values and registrated new user
        private void Register_btn_Click(object sender, RoutedEventArgs e)
        {
            
            
            string register_user_login = registration_login.Text.Trim();
            string register_user_email = registration_email.Text.Trim().ToLower();
            string register_user_pass1 = registration_pass1.Password.Trim();
            string register_user_pass2 = registration_pass2.Password.Trim();
            string admin_status = "false";
            
            if (register_user_login.Length < 4)
            {
                registration_login.ToolTip = "Длина логина должна быть больше 4 символов";
                registration_login.BorderBrush = Brushes.Crimson;
            } else
            {
                registration_login.ToolTip = null;
                registration_login.BorderBrush = Brushes.Black;
            }


            if (register_user_pass1.Length < 4)
            {
                registration_pass1.ToolTip = "Длина пароля должна быть больше 4 символов";
                registration_pass1.BorderBrush = Brushes.Crimson;
            } else
            {
                registration_pass1.ToolTip = null;
                registration_pass1.BorderBrush = Brushes.Black;
            }


            if (register_user_pass1 != register_user_pass2)
            {
                registration_pass1.ToolTip = "Пароли не совпадают";
                registration_pass1.BorderBrush = Brushes.Crimson;
                registration_pass2.ToolTip = "Пароли не совпадают";
                registration_pass2.BorderBrush = Brushes.Crimson;
            } else if (register_user_pass1.Length < 4)
            {
                
                registration_pass1.ToolTip = "Длина пароля должна быть больше 4 символов";
                registration_pass2.ToolTip = "Длина пароля должна быть больше 4 символов";
            } else
            {
                registration_pass1.ToolTip = null;
                registration_pass1.BorderBrush = Brushes.Black;
                registration_pass2.BorderBrush = Brushes.Black;
                registration_pass2.ToolTip = null;
            }


            if (register_user_email.Length < 5)
            {
                registration_email.ToolTip = "Длина почты должна быть больше 5 символов";
                registration_email.BorderBrush = Brushes.Crimson;
            } else
            {
                registration_email.ToolTip = null;
                registration_email.BorderBrush = Brushes.Black;
            }


            if (!register_user_email.Contains('@') || !register_user_email.Contains('.'))
            {
                registration_email.ToolTip = "Почта введена неправильно";
                registration_email.BorderBrush = Brushes.Crimson;
            } else if (register_user_email.Length < 5)
            {
                registration_email.ToolTip = "Длина почты должна быть больше 5 символов";
            } else
            {
                registration_email.ToolTip = null;
                registration_email.BorderBrush = Brushes.Black;
            }


            if (register_user_login.Length >= 4 && register_user_pass1.Length >= 4 && register_user_pass1 == register_user_pass2 && (register_user_email.Contains('@') && register_user_email.Contains('.')))
            {
                registration_email.ToolTip = null;
                registration_pass1.ToolTip = null;
                registration_pass2.ToolTip = null;
                registration_login.ToolTip = null;

                user user = new user(register_user_login,register_user_email,register_user_pass1,admin_status);
                    
                db.users.Add(user);
                db.SaveChanges();
                register_grid.Visibility = Visibility.Hidden;
                main_menu_grid.Visibility = Visibility.Visible;
                MessageBox.Show("Регистрация проведена успешно");

                registration_login.Text = "";
                registration_email.Text = "";
                registration_pass1.Password = "";
                registration_pass2.Password = "";


            }
        }
        // function for check values in textboxes and login in account
        void login_account()
        {
            string user_login = login_textbox.Text.Trim();
            string user_pass = pass_textbox.Password.Trim();

            if (user_login.Length < 4)
            {
                login_textbox.ToolTip = "Длина логина должна быть больше 4 символов";
                login_textbox.BorderBrush = Brushes.Crimson;
            }
            else
            {
                login_textbox.ToolTip = null;
                login_textbox.BorderBrush = Brushes.Black;
            }


            if (user_pass.Length < 4)
            {
                pass_textbox.ToolTip = "Длина пароля должна быть больше 4 символов";
                pass_textbox.BorderBrush = Brushes.Crimson;
            }
            else
            {
                pass_textbox.ToolTip = null;
                pass_textbox.BorderBrush = Brushes.Black;
            }
            if (user_login.Length >= 4 && user_pass.Length >= 4)
            {
                user authUser = null;
                //user user_id = null;
                using (ApplicationContext db = new ApplicationContext())
                {
                    authUser = db.users.Where(b => b.Login == user_login && b.Password == user_pass).FirstOrDefault();
                }
                if (authUser != null)
                {
                    MessageBox.Show("Успешно!");
                    current_user_id = authUser.id;
                    //MessageBox.Show(user_id);
                    if (authUser.Admin_status == "true")
                    {
                        user_type = 2;
                        history_button.IsEnabled = true; //admin panel
                    }
                    else
                    {
                        user_type = 1;
                        history_button.IsEnabled = false; //admin panel
                    }
                    history_btn.IsEnabled = true;
                    profile_user_mail = authUser.Email;
                    profile_user_login = authUser.Login;
                    grid_menu.Visibility = Visibility.Visible;
                    main_menu_grid.Visibility = Visibility.Hidden;
                    login_textbox.Text = "";
                    pass_textbox.Password = "";
                    textblock_paint_result.Text = "Выберете \"Тип расчёта\"";
                }
                else
                {
                    user_type = 0;
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }
        private void Login_btn_Click(object sender, RoutedEventArgs e)
        {
            login_account();
        }
        private MediaPlayer player = new MediaPlayer();
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            new About1().ShowDialog();
        }
        // login form button
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            register_grid.Visibility = Visibility.Hidden;
            main_menu_grid.Visibility = Visibility.Visible;
        }
        // exit button
        private void Exit_account_btn_Click(object sender, RoutedEventArgs e)
        {
            admin_grid.Visibility = Visibility.Hidden;
            register_grid.Visibility = Visibility.Hidden;
            grid_menu.Visibility = Visibility.Hidden;
            history_grid.Visibility = Visibility.Hidden;
          //grid_paint_calc.Visibility = Visibility.Hidden;
          //paint_options_grid.Visibility = Visibility.Hidden;
          //space_grid.Visibility = Visibility.Hidden;
            main_menu_grid.Visibility = Visibility.Visible;
            hide_menu2(1);
            hide_paint_calc(1);
            user_type = 0;
            current_user_id = 1;
            
        }
        //when press "enter button" in login form
        private void login_key_enter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                login_account();
            }
        }
        void hide_menu2(int i)
        {
            if (i == 1)
            {
                menu2_grid.Visibility = Visibility.Hidden;
            } else
            {
                menu2_grid.Visibility = Visibility.Visible;
            }
            
        }
        void hide_paint_calc(int i)
        {
            if (i == 1)
            {
                grid_paint_calc.Visibility = Visibility.Hidden;
                paint_options_grid.Visibility = Visibility.Hidden;
                space_grid.Visibility = Visibility.Hidden;
                

            } else
            {
                grid_paint_calc.Visibility = Visibility.Visible;
                paint_options_grid.Visibility = Visibility.Visible;
                if (space_check_value)
                {
                    space_grid.Visibility = Visibility.Visible;
                }
                else
                {
                    space_grid.Visibility = Visibility.Hidden;
                }
            }
        }
        void hide_history_calc(int i)
        {
            if (i == 1)
            {
                history_grid.Visibility = Visibility.Hidden;
            }
            else
            {
                history_grid.Visibility = Visibility.Visible;
            }
        }
        void hide_profile(int i)
        {
            if (i > 0)
            {
                profile_grid1.Visibility = Visibility.Hidden;
            }
            else
            {
                profile_grid1.Visibility = Visibility.Visible;
            }
        }
        void hide_all_pages()
        {
            hide_paint_calc(1);
        }
=======
            }

        }

        Boolean grid_paint1 = true;

        public object RootLayout { get; private set; }
        //paint calc button
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //if (grid_paint1)
           // {
                //grid_paint_calc.Visibility = Visibility.Visible;
                //paint_options_grid.Visibility = Visibility.Visible;
                //grid_paint1 = !grid_paint1;
                //paint_calcs_btn.Visibility = Visibility.Hidden;
                hide_menu2(1);
                hide_paint_calc(0);
                
            /*}
            else
            {
                //grid_paint_calc.Visibility = Visibility.Hidden;
                //paint_options_grid.Visibility = Visibility.Hidden;
                //space_grid.Visibility = Visibility.Hidden;
                hide_menu2(0);
                hide_paint_calc(1);
                grid_paint1 = !grid_paint1;
            }*/
        }
        //Кнопка истории расчётов
        public class MyItem
        {
            public int id_calc { get; set; }

            public string date_calc { get; set; }
            public string type_calc { get; set; }
            public string square_calc { get; set; }
            public string square2_calc { get; set; }

        }
        public class MyItem2
        {
            public int user_id { get; set; }

            public string user_login { get; set; }
            public string user_mail { get; set; }
            public string user_pass { get; set; }
            public string user_admin { get; set; }

        }
        /*private void Button_delete_Click(object sender, RoutedEventArgs e)
        {
            //Button button = sender as Button;
            //Game game = button.DataContext as Game;
            //int id = game.ID;
            //int inex1 = sender.SelectedIndex
            int list_index = calcs_out_listview.SelectedIndex;
            MessageBox.Show("удалить запись номер "+ list_index + " ?");
        }*/
        private void profile_btn_Click(object sender, RoutedEventArgs e)
        {
            //history_listbox
            hide_menu2(1);
            hide_history_calc(0);
            calcs_history_update();
        }
        public void users_list_update()
        {
            List<user> users = db.users.ToList();

            var md5 = MD5.Create();
            int admin_count = 0;

            users_listview.Items.Clear();
            foreach (user user in users)
            {
                if (user.Admin_status != "true")
                {
                    int list_user_id = user.id;
                    string list_user_login = user.Login, list_user_mail = user.Email, list_user_admin = user.Admin_status;
                    string list_user_pass = user.Password;
                    list_user_pass = Convert.ToBase64String(md5.ComputeHash(Encoding.UTF8.GetBytes(list_user_pass)));
                    users_listview.Items.Add(new MyItem2 { user_id = list_user_id, user_login = list_user_login, user_mail = list_user_mail, user_pass = list_user_pass, user_admin = list_user_admin });
                }
                else
                {
                    admin_count++;
                }
                
            }
            MessageBox.Show("Пользователей со статусом администратора = " + admin_count);
        }
        public void calcs_history_update()
        {
            List<input_paints> inputs;
            List<output_paints> outputs;
            if (user_type == 2)
            {
                inputs = db.input_paint.ToList();
                outputs = db.output_paint.ToList();
            } else
            {
                inputs = db.input_paint.Where(b => b.User_id == current_user_id.ToString()).ToList();
                outputs = db.output_paint.Where(b => b.User_id == current_user_id.ToString()).ToList();
            }
            calcs_out_listview.Items.Clear();
            foreach (input_paints input in inputs)
            {
                int cur_id = input.id;
                int out_id;
                string out_square = "0", out_square2 = "0";
                foreach (output_paints output in outputs)
                {
                    if (output.id == cur_id)
                    {
                        out_id = output.id;
                        out_square = output.Wall_square;
                        out_square2 = output.Ceiling_area;
                    }
                }
                calcs_out_listview.Items.Add(new MyItem { id_calc = input.id, date_calc = input.Date, type_calc = input.Calc_type, square_calc = out_square, square2_calc = out_square2 });
            }
        }
        private void calcs_out_listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
=======
=======
        {

        }

        //go to main menu button
        Boolean menu_btn = false;
        private void Main_menu_btn_Click(object sender, RoutedEventArgs e)
>>>>>>> Stashed changes
        {
            if (menu_btn)
            {
                hide_menu2(0);
                admin_grid.Visibility = Visibility.Hidden;
                hide_paint_calc(1);
                hide_profile(1);
                hide_history_calc(1);

                menu_btn = !menu_btn;
            } else
            {
                hide_menu2(0);
                admin_grid.Visibility = Visibility.Hidden;
                hide_paint_calc(1);
                hide_history_calc(1);
                hide_profile(1);

                menu_btn = !menu_btn;
            }
        }
        byte selected_type_of_calc;

<<<<<<< Updated upstream
        //go to main menu button
        Boolean menu_btn = false;
        private void Main_menu_btn_Click(object sender, RoutedEventArgs e)
>>>>>>> Stashed changes
=======
        // delete calc button
        private void Button_Click_8(object sender, RoutedEventArgs e)
>>>>>>> Stashed changes
        {
            if (menu_btn)
            {
                hide_menu2(0);
                admin_grid.Visibility = Visibility.Hidden;
                hide_paint_calc(1);
                hide_profile(1);
                hide_history_calc(1);

<<<<<<< Updated upstream
                menu_btn = !menu_btn;
            } else
            {
                hide_menu2(0);
                admin_grid.Visibility = Visibility.Hidden;
                hide_paint_calc(1);
                hide_history_calc(1);
                hide_profile(1);

                menu_btn = !menu_btn;
            }
        }
        byte selected_type_of_calc;

<<<<<<< Updated upstream
        //go to main menu button
        Boolean menu_btn = false;
        private void Main_menu_btn_Click(object sender, RoutedEventArgs e)
>>>>>>> Stashed changes
=======
        // delete calc button
        private void Button_Click_8(object sender, RoutedEventArgs e)
>>>>>>> Stashed changes
        {
            if (menu_btn)
            {
                hide_menu2(0);
                admin_grid.Visibility = Visibility.Hidden;
                hide_paint_calc(1);
                hide_profile(1);
                hide_history_calc(1);

                menu_btn = !menu_btn;
            } else
            {
                hide_menu2(0);
                admin_grid.Visibility = Visibility.Hidden;
                hide_paint_calc(1);
                hide_history_calc(1);
                hide_profile(1);

<<<<<<< Updated upstream
                menu_btn = !menu_btn;
=======
            var a = Int32.TryParse(deleted_calcs_id_textbox.Text.ToString(), out int value_1);
            if (a)
            {
                int delete_id = Math.Abs(Int32.Parse(deleted_calcs_id_textbox.Text.ToString()));
                try
                {
                    var input_del = db.input_paint.FirstOrDefault(x => x.id == delete_id);
                    db.input_paint.Remove(input_del);
                    db.SaveChanges();
                    var output_del = db.output_paint.FirstOrDefault(x => x.id == delete_id);
                    db.output_paint.Remove(output_del);
                    db.SaveChanges();
                    calcs_history_update();
                }
                catch
                {

                }
            }
            else
            {
                warning_number_window();
>>>>>>> Stashed changes
            }
        }
        byte selected_type_of_calc;

<<<<<<< Updated upstream
<<<<<<< Updated upstream
        //go to main menu button
        Boolean menu_btn = false;
        private void Main_menu_btn_Click(object sender, RoutedEventArgs e)
=======
        // delete calc button
        private void Button_Click_8(object sender, RoutedEventArgs e)
>>>>>>> Stashed changes
        {
            if (menu_btn)
            {
                hide_menu2(0);
                admin_grid.Visibility = Visibility.Hidden;
                hide_paint_calc(1);
                hide_profile(1);
                hide_history_calc(1);

                menu_btn = !menu_btn;
            } else
            {
                hide_menu2(0);
                admin_grid.Visibility = Visibility.Hidden;
                hide_paint_calc(1);
                hide_history_calc(1);
                hide_profile(1);

<<<<<<< Updated upstream
                menu_btn = !menu_btn;
=======
            var a = Int32.TryParse(deleted_calcs_id_textbox.Text.ToString(), out int value_1);
            if (a)
            {
                int delete_id = Math.Abs(Int32.Parse(deleted_calcs_id_textbox.Text.ToString()));
                try
                {
                    var input_del = db.input_paint.FirstOrDefault(x => x.id == delete_id);
                    db.input_paint.Remove(input_del);
                    db.SaveChanges();
                    var output_del = db.output_paint.FirstOrDefault(x => x.id == delete_id);
                    db.output_paint.Remove(output_del);
                    db.SaveChanges();
                    calcs_history_update();
                }
                catch
                {

                }
            }
            else
            {
                warning_number_window();
>>>>>>> Stashed changes
            }
        }
        byte selected_type_of_calc;

<<<<<<< Updated upstream
        // delete calc button
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

=======
>>>>>>> Stashed changes
            var a = Int32.TryParse(deleted_calcs_id_textbox.Text.ToString(), out int value_1);
            if (a)
            {
                int delete_id = Math.Abs(Int32.Parse(deleted_calcs_id_textbox.Text.ToString()));
                try
                {
                    var input_del = db.input_paint.FirstOrDefault(x => x.id == delete_id);
                    db.input_paint.Remove(input_del);
                    db.SaveChanges();
                    var output_del = db.output_paint.FirstOrDefault(x => x.id == delete_id);
                    db.output_paint.Remove(output_del);
                    db.SaveChanges();
                    calcs_history_update();
                }
                catch
                {

                }
            }
            else
            {
                warning_number_window();
            }
        }
<<<<<<< Updated upstream


        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
=======

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
>>>>>>> Stashed changes
            grid_menu.Visibility = Visibility.Visible;
            main_menu_grid.Visibility = Visibility.Hidden;
            history_button.IsEnabled = false;
            history_btn.IsEnabled = false;
            add_room_button.IsEnabled = false;
            account_info_btn.IsEnabled = false;
            user_type = 3;
<<<<<<< Updated upstream

            login_textbox.Text = "";
            pass_textbox.Password = "";
            textblock_paint_result.Text = "Выберете \"Тип расчёта\"";
        }

        
        private void wallpaper_check_Checked(object sender, RoutedEventArgs e)
        {
            check_wall = true;
            wallpapers_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }
        private void wallpaper_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_wall = false;
            wallpapers_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        // 0:31 am fuck
        int grid_number = 2;
        int grids = 0;
        Boolean grid_first = true;
        public void adaptive_epta()
        {
            if (!grid_first)
            {
                //grids += 1;
                while (grids > 0)
                {
                    grid_griddiest.RowDefinitions.RemoveAt(grids);
                    //grid_griddiest.RowDefinitions.Remove(new RowDefinition());
                    grids--;
                }
                
            } else
            {
                grid_first = false;
            }
            if (check_wall)
            {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto } );
                wallpapers_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            }
            if (check_plaster)
            {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                plaster_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            } if (check_grunt)
            {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                grunt_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            } if (check_ground_coat) {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                ground_coat_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            } if (check_paint)
            {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                paint_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            }
            grid_number = 2;

        }

        Boolean first_here = true;
        Boolean check_wall = false;
        Boolean check_plaster = false;
        Boolean check_grunt = false;
        Boolean check_ground_coat = false;
        Boolean check_paint = false;

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
           new _3d_model(width1, length1, height1, height1, height1).ShowDialog();
        }

        //profile updater
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
          /*  login_info_textbox.Text = null;
            mail_info_textbox.Text = null;
            pass_info_textbox.Text = null;
            pass2_info_textbox.Text = null;*/

            string login_update = update_login.Text.Trim();
            string mail_update = update_email.Text.Trim().ToLower();
            string pass1_update = update_pass1.Password.Trim();
            string pass2_update = update_pass2.Password.Trim();

            mail_update = (mail_update == "") ? mail_update = null : mail_update = mail_update;
            pass1_update = (pass1_update == "") ? pass1_update = null : pass1_update = pass1_update;
            pass2_update = (pass2_update == "") ? pass2_update = null : pass2_update = pass2_update;

            if (mail_update != null || pass1_update != null || pass2_update != null)
            {
                update_email.Text = null;
                
                var md5 = MD5.Create();
                string pass_md5 = "300$";
                try
                {
                    md5 = MD5.Create();
                    pass_md5 = Convert.ToBase64String(md5.ComputeHash(Encoding.UTF8.GetBytes(pass1_update)));
                }
                catch
                {
                    MessageBox.Show("Ошибка с MD5");
                }
                user login_check;
                using (ApplicationContext db = new ApplicationContext())
                {
                    login_check = db.users.Where(b => b.Login == profile_user_login).FirstOrDefault();
                }
                user updating = null;





                if (pass1_update != pass2_update)
                {
                    update_pass1.ToolTip = "Пароли не совпадают";
                    update_pass1.BorderBrush = Brushes.Crimson;
                    update_pass2.ToolTip = "Пароли не совпадают";
                    update_pass2.BorderBrush = Brushes.Crimson;

                }
                else if (pass2_update.Length < 4 && pass1_update.Length < 4)
                {

                    update_pass1.ToolTip = "Длина пароля должна быть больше 4 символов";
                    update_pass2.ToolTip = "Длина пароля должна быть больше 4 символов";
                    update_pass1.BorderBrush = Brushes.Crimson;
                    update_pass2.BorderBrush = Brushes.Crimson;
                } else if (pass1_update != null && pass2_update != null)
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        updating = db.users.Where(b => b.Login == profile_user_login).FirstOrDefault();
                        updating.Password = pass_md5;
                        db.SaveChanges();

                    }

                    MessageBox.Show("Пароль изменен");
                    MessageBox.Show(update_pass1.ToString());
                    update_pass1.ToolTip = null;
                    update_pass1.BorderBrush = Brushes.Black;
                    update_pass2.BorderBrush = Brushes.Black;
                    update_pass2.ToolTip = null;
                    update_pass1.Password = null;
                    update_pass2.Password = null;
                }


                if (mail_update.Length < 5)
                {
                    update_email.ToolTip = "Длина почты должна быть больше 5 символов";
                    update_email.BorderBrush = Brushes.Crimson;
                }
                else
                {
                    update_email.ToolTip = null;
                    update_email.BorderBrush = Brushes.Black;
                }


                if (!mail_update.Contains('@') || !mail_update.Contains('.'))
                {
                    update_email.ToolTip = "Почта введена неправильно";
                    update_email.BorderBrush = Brushes.Crimson;
                }
                else if (mail_update.Length < 5)
                {
                    update_email.ToolTip = "Длина почты должна быть больше 5 символов";
                }
                else
                {
                    if (updating != null)
                    {
                        updating.Email = mail_update;
                    }
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        updating = db.users.Where(b => b.Login == profile_user_login).FirstOrDefault();
                        updating.Email = mail_update;
                        db.SaveChanges();
                    }
                    
                    MessageBox.Show("Почта изменена");
                    update_email.ToolTip = null;
                    update_email.BorderBrush = Brushes.Black;

                }


                
                } else
                {
                MessageBox.Show("Ничего не изменилось 🤨");
                }
        }

        private void plaster_check_Checked(object sender, RoutedEventArgs e)
        {
            check_plaster = true;
            plaster_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }

        private void plaster_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_plaster = false;
            plaster_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        private void grunt_check_Checked(object sender, RoutedEventArgs e)
        {
            check_grunt = true;
            grunt_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }

        private void grunt_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_grunt = false;
            grunt_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        private void ground_coat_check_Checked(object sender, RoutedEventArgs e)
        {
            check_ground_coat = true;
            ground_coat_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }

        private void ground_coat_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_ground_coat = false;
            ground_coat_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        private void paint_check_Checked(object sender, RoutedEventArgs e)
        {
            check_paint = true;
            paint_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }

        private void paint_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_paint = false;
            paint_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        int type_calc_check = 0;
        //when type of calc changed
        private void Paint_calcs_combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            selected_type_of_calc = Convert.ToByte(paint_calcs_combobox.SelectedIndex + 1);
            //MessageBox.Show(selected_type_of_calc.ToString());
            //Thickness space_margin = space_grid.Margin;
            textblock_paint_result.Text = "Нажмите \"Рассчитать\"";
            switch (selected_type_of_calc)
            {
                case 1:
                    //space_grid.Margin = new Thickness(0, 300, 0, 0);
                    //textblock_paint_result.Margin = new Thickness(0, 115, 0, 0);
                    spaces_top = 100;
                    height2_grid.Visibility = Visibility.Hidden;
                    height3_grid.Visibility = Visibility.Hidden;
                    height4_grid.Visibility = Visibility.Hidden;
                    type_calc_check = 1;
                    if (first_here)
                    {
                        do_calculation.IsEnabled = true;
                    } else if (rooms) {
                        do_calculation.IsEnabled = false;
                    }
                    if (user_type != 3 && first_here || rooms) add_room_button.IsEnabled = true; 
                    else
                        add_room_button.IsEnabled = false;
                    first_here = false;
                    break;
                case 2:
                    type_calc_check = 2;
                    //space_grid.Margin = new Thickness(0, 345, 0, 0);
                    //textblock_paint_result.Margin = new Thickness(0, 160, 0, 0);
                    height2_grid.Visibility = Visibility.Visible;
                    height3_grid.Visibility = Visibility.Hidden;
                    height4_grid.Visibility = Visibility.Hidden;
                    spaces_top = 170;

                    if (first_here)
                    {
                        do_calculation.IsEnabled = true;
                    }
                    else if (rooms)
                    {
                        do_calculation.IsEnabled = false;
                    }
                    if (user_type != 3 && first_here || rooms) add_room_button.IsEnabled = true;
                    else
                        add_room_button.IsEnabled = false;
                    first_here = false;
                    break;
                case 3:
                    type_calc_check = 3;
                    height2_grid.Visibility = Visibility.Visible;
                    height3_grid.Visibility = Visibility.Visible;
                    height4_grid.Visibility = Visibility.Visible;
                    spaces_top = 170;
                    if (first_here)
                    {
                        do_calculation.IsEnabled = true;
                    }
                    else if (rooms)
                    {
                        do_calculation.IsEnabled = false;
                    }
                    if (user_type != 3 && first_here || rooms) add_room_button.IsEnabled = true;
                    else
                        add_room_button.IsEnabled = false;
                    first_here = false;
                    break;
                /*case 4:
                    type_calc_check = 4;
                    if (first_here)
                    {
                        do_calculation.IsEnabled = true;
                    }
                    else if (rooms)
                    {
                        do_calculation.IsEnabled = false;
                    }
                    if (user_type != 3 && first_here || rooms) add_room_button.IsEnabled = true;
                    else
                        add_room_button.IsEnabled = false;
                    first_here = false;
                    break;*/
            }
            space_grid.Margin = new Thickness(0, spaces_top, 190, 4);
        }
        // add space button
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            space_width = check_value(space_width_textbox.Text);
            space_height = check_value(space_height_textbox.Text);
            if (space_height > 0 && space_width > 0)
            {
                space_id++;
                space_square = space_width * space_height;
                space_listbox.Items.Add("Проем №" + space_id + ", Ширина - " + space_width + ", Высота - " + space_height + ", Площадь - " + space_square + " - " + measure_ln + "\u00B2");
                all_space_square += space_square;
            } else
            {
                warning_number_window();
            }
        }


        private void Space_history_listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Account_info_btn_Click(object sender, RoutedEventArgs e)
        {
            hide_profile(0);
            hide_menu2(1);
            update_login.Text = profile_user_login;
            update_email.Text = profile_user_mail;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void history_button_Click(object sender, RoutedEventArgs e)
        {
            admin_grid.Visibility = Visibility.Visible;
            hide_menu2(1);
            users_list_update();
        }

        private void delete_user_button_Click(object sender, RoutedEventArgs e)
        {
            var a = Int32.TryParse(deleted_user_id_textbox.Text.ToString(), out int value_1);
            if (a)
            {
                int delete_id = Math.Abs(Int32.Parse(deleted_user_id_textbox.Text.ToString()));
                user admin_stat = null;
                using (ApplicationContext db = new ApplicationContext())
                {
                    admin_stat = db.users.Where(b => b.id == delete_id).FirstOrDefault();
                }
                try
                {
                    if (admin_stat != null)
                    {

                        if (admin_stat.Admin_status != "true")
                        {
                            try
                            {
                                var input_del = db.users.FirstOrDefault(x => x.id == delete_id);
                                db.users.Remove(input_del);
                                db.SaveChanges();
                                users_list_update();
                            }
                            catch
                            {

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка");
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
            else
            {
                warning_number_window();
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            void Create(string filePath)
            {
                string calc_id, user_id, calc_type, an1, an2, an3, an4, w1, w2, l1, l2, h1, h2, h3, h4, space_square, date;
                string wall_square, ceiling_perimetr, ceiling_area, ground_area, ground_perimetr, height_length;
                List<input_paints> inputs;
                List<output_paints> outputs;
                List<materials> materials;
                if (user_type == 2)
                {
                    inputs = db.input_paint.ToList();
                    outputs = db.output_paint.ToList();
                    materials = db.material.ToList();
                }
                else
                {
                    inputs = db.input_paint.Where(b => b.User_id == current_user_id.ToString()).ToList();
                    outputs = db.output_paint.Where(b => b.User_id == current_user_id.ToString()).ToList();
                    materials = db.material.Where(b => b.User_id == current_user_id.ToString()).ToList();
                }

                string a_col = "A", b_col = "B", c_col = "C", d_col = "D", e_col = "E", f_col = "F", g_col = "G", h_col = "H";
                string i_col = "I", j_col = "J", k_col = "K", l_col = "L", m_col = "M", n_col = "N", o_col = "O", p_col = "P";
                string q_col = "Q", r_col = "R", s_col = "S", t_col = "T", u_col = "U", v_col = "V", w_col = "W", x_col = "X";
                int row_count = 2;

                var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add("Расчёты");

                var colu_a1 = ws.Column("A");
                var colu_b1 = ws.Column("B");
                var colu_c1 = ws.Column("C");
                var colu_d1 = ws.Column("D");
                var colu_e1 = ws.Column("E");
                var colu_f1 = ws.Column("F");
                var colu_g1 = ws.Column("G");
                var colu_h1 = ws.Column("H");
                var colu_i1 = ws.Column("I");
                var colu_j1 = ws.Column("J");
                var colu_k1 = ws.Column("K");
                var colu_l1 = ws.Column("L");
                var colu_m1 = ws.Column("M");
                var colu_n1 = ws.Column("N");
                var colu_o1 = ws.Column("O");
                var colu_p1 = ws.Column("P");
                var colu_q1 = ws.Column("Q");
                var colu_r1 = ws.Column("R");
                var colu_s1 = ws.Column("S");
                var colu_t1 = ws.Column("T");
                var colu_u1 = ws.Column("U");
                var colu_v1 = ws.Column("V");
                var colu_w1 = ws.Column("W");
                var colu_x1 = ws.Column("X");



                colu_a1.Width = 9; colu_b1.Width = 15; colu_c1.Width = 11; colu_d1.Width = 9; colu_e1.Width = 9; colu_f1.Width = 9;
                colu_g1.Width = 9; colu_h1.Width = 11; colu_i1.Width = 11; colu_j1.Width = 11; colu_k1.Width = 11; colu_l1.Width = 11;
                colu_m1.Width = 11; colu_n1.Width = 11; colu_o1.Width = 11; colu_p1.Width = 11; colu_q1.Width = 17;
                colu_r1.Width = 17; colu_s1.Width = 13; colu_t1.Width = 14; colu_u1.Width = 17; colu_v1.Width = 24; colu_w1.Width = 20; colu_x1.Width = 20;

                var rngTable1 = ws.Range("A1:X1");
                var rngHeaders1 = rngTable1.Range("A1:X1");
                rngHeaders1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders1.Style.Font.Bold = true;
                rngHeaders1.Style.Fill.BackgroundColor = XLColor.Aqua;

                var rngtable1 = ws.Range("A2:X200");
                var rngnumbers1 = rngtable1.Range("A2:X200");
                rngnumbers1.DataType = XLDataType.Number;
                rngnumbers1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                ws.Cell("A1").Value = "Id Расчета";
                ws.Cell("B1").Value = "Id Пользователя";
                ws.Cell("C1").Value = "Тип расчёта";
                ws.Cell("D1").Value = "Угол №1";
                ws.Cell("E1").Value = "Угол №2";
                ws.Cell("F1").Value = "Угол №3";
                ws.Cell("G1").Value = "Угол №4";
                ws.Cell("H1").Value = "Ширнина №1";
                ws.Cell("I1").Value = "Ширнина №2";
                ws.Cell("J1").Value = "Длина №1";
                ws.Cell("K1").Value = "Длина №2";
                ws.Cell("L1").Value = "Высота №1";
                ws.Cell("M1").Value = "Высота №2";
                ws.Cell("N1").Value = "Высота №3";
                ws.Cell("O1").Value = "Высота №4";
                ws.Cell("P1").Value = "Площадь стен";
                ws.Cell("Q1").Value = "Периметр потолка";
                ws.Cell("R1").Value = "Площадь потолка";
                ws.Cell("S1").Value = "Площадь пола";
                ws.Cell("T1").Value = "Периметр пола";
                ws.Cell("U1").Value = "Площадь проемов";
                ws.Cell("V1").Value = "Общая высота всех углов";
                ws.Cell("W1").Value = "Дата";
                ws.Cell("X1").Value = "Номер комнаты";


                foreach (input_paints input in inputs)
                {
                    int cur_id = input.id;
                    calc_id = cur_id.ToString();
                    user_id = current_user_id.ToString();
                    calc_type = input.Calc_type;
                    an1 = input.An1;
                    an2 = input.An2;
                    an3 = input.An3;
                    an4 = input.An4;
                    w1 = input.W1;
                    w2 = input.W2;
                    l1 = input.L1;
                    l2 = input.L2;
                    h1 = input.H1;
                    h2 = input.H2;
                    h3 = input.H3;
                    h4 = input.H4;
                    string h5 = input.Room_number;
                    space_square = input.Space_square;
                    date = input.Date;
                    int out_id;
                    string out_square = "0", out_square2 = "0";
                    foreach (output_paints output in outputs)
                    {

                        if (output.id == cur_id)
                        {
                            wall_square = output.Wall_square;
                            ceiling_perimetr = output.Ceiling_perimetr;
                            ceiling_area = output.Ceiling_area;
                            ground_area = output.Ground_area;
                            ground_perimetr = output.Ground_perimetr;
                            height_length = output.Height_lenght;

                            a_col += row_count.ToString();
                            b_col += row_count.ToString();
                            c_col += row_count.ToString();
                            d_col += row_count.ToString();
                            e_col += row_count.ToString();
                            f_col += row_count.ToString();
                            g_col += row_count.ToString();
                            h_col += row_count.ToString();
                            i_col += row_count.ToString();
                            j_col += row_count.ToString();
                            k_col += row_count.ToString();
                            l_col += row_count.ToString();
                            m_col += row_count.ToString();
                            n_col += row_count.ToString();
                            o_col += row_count.ToString();
                            p_col += row_count.ToString();
                            q_col += row_count.ToString();
                            r_col += row_count.ToString();
                            s_col += row_count.ToString();
                            t_col += row_count.ToString();
                            u_col += row_count.ToString();
                            v_col += row_count.ToString();
                            w_col += row_count.ToString();
                            x_col += row_count.ToString();

                            ws.Cell(a_col).Value = cur_id;
                            ws.Cell(b_col).Value = current_user_id;
                            ws.Cell(c_col).Value = calc_type;
                            ws.Cell(d_col).Value = an1;
                            ws.Cell(e_col).Value = an2;
                            ws.Cell(f_col).Value = an3;
                            ws.Cell(g_col).Value = an4;
                            ws.Cell(h_col).Value = w1;
                            ws.Cell(i_col).Value = w2;
                            ws.Cell(j_col).Value = l1;
                            ws.Cell(k_col).Value = l2;
                            ws.Cell(l_col).Value = h1;
                            ws.Cell(m_col).Value = h2;
                            ws.Cell(n_col).Value = h3;
                            ws.Cell(o_col).Value = h4;
                            ws.Cell(p_col).Value = wall_square;
                            ws.Cell(q_col).Value = ceiling_perimetr;
                            ws.Cell(r_col).Value = ceiling_area;
                            ws.Cell(s_col).Value = ground_area;
                            ws.Cell(t_col).Value = ground_perimetr;
                            ws.Cell(u_col).Value = space_square;
                            ws.Cell(v_col).Value = height_length;
                            ws.Cell(w_col).Value = date;
                            ws.Cell(x_col).Value = h5;
                            a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                            i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                            q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                            row_count++;
                        }
                    }

                    
                }
                a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                row_count = 2;
                var ws2 = wb.Worksheets.Add("Обои, Штукатурка");
                ws2.Cell("A1").Value = "Id Расчета";
                ws2.Cell("B1").Value = "Id Пользователя";
                ws2.Cell("C1").Value = "Ширина обоев";
                ws2.Cell("D1").Value = "Ширина рулона";
                ws2.Cell("E1").Value = "Длина обоев";
                ws2.Cell("F1").Value = "Кол-во рулонов";
                ws2.Cell("G1").Value = "Кол-во слоев штукатурки";
                ws2.Cell("H1").Value = "Вес емкости штукатурки";
                ws2.Cell("I1").Value = "Расход емкости";
                ws2.Cell("J1").Value = "Площадь расхода";
                ws2.Cell("K1").Value = "Вес емкостей";
                ws2.Cell("L1").Value = "Кол-во емкостей";
                //ws2.Cell("M1").Value = "Дата";
                var colu_a = ws2.Column("A");
                var colu_b = ws2.Column("B");
                var colu_c = ws2.Column("C");
                var colu_d = ws2.Column("D");
                var colu_e = ws2.Column("E");
                var colu_f = ws2.Column("F");
                var colu_g = ws2.Column("G");
                var colu_h = ws2.Column("H");
                var colu_i = ws2.Column("I");
                var colu_j = ws2.Column("J");
                var colu_k = ws2.Column("K");
                var colu_l = ws2.Column("L");

                var rngTable2 = ws2.Range("A1:L1");
                var rngHeaders2 = rngTable2.Range("A1:L1");
                rngHeaders2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders2.Style.Font.Bold = true;
                rngHeaders2.Style.Fill.BackgroundColor = XLColor.Aqua;

                var rngtable2 = ws2.Range("A2:W200");
                var rngnumbers2 = rngtable2.Range("A2:W200");
                rngnumbers2.DataType = XLDataType.Number;
                rngnumbers2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                colu_a.Width = 9; colu_b.Width = 14; colu_c.Width = 13; colu_d.Width = 13.5; colu_e.Width = 11; colu_f.Width = 13.5;
                colu_g.Width = 21.5; colu_h.Width = 20; colu_i.Width = 13.5; colu_j.Width = 15.3; colu_k.Width = 12; colu_l.Width = 15;


                foreach (materials material in materials)
                {
                    int cur_id2 = material.id;
                    calc_id = cur_id2.ToString();
                    user_id = current_user_id.ToString();
                    calc_type = material.In_wallpapers_width;
                    an1 = material.In_wallpapers_circle_length;
                    an2 = material.Wallpapers_length_m;
                    an3 = material.Wallpapers_amount;
                    an4 = material.In_plaster_thick;
                    w1 = material.In_plaster_kg_mesh;
                    w2 = material.In_plaster_m_mesh;
                    l1 = material.Plaster_volume_m;
                    l2 = material.Plaster_kg;
                    h1 = material.Plaster_amount;
                    //date = material.Date;
                    int out_id2;
                    //string out_square = "0", out_square2 = "0";


                    if (material.id == cur_id2)
                    {
                        /*wall_square = output.Wall_square;
                        ceiling_perimetr = output.Ceiling_perimetr;
                        ceiling_area = output.Ceiling_area;
                        ground_area = output.Ground_area;
                        ground_perimetr = output.Ground_perimetr;
                        height_length = output.Height_lenght;*/

                        a_col += row_count.ToString();
                        b_col += row_count.ToString();
                        c_col += row_count.ToString();
                        d_col += row_count.ToString();
                        e_col += row_count.ToString();
                        f_col += row_count.ToString();
                        g_col += row_count.ToString();
                        h_col += row_count.ToString();
                        i_col += row_count.ToString();
                        j_col += row_count.ToString();
                        k_col += row_count.ToString();
                        l_col += row_count.ToString();
                        //m_col += row_count.ToString();


                        ws2.Cell(a_col).Value = cur_id2;
                        ws2.Cell(b_col).Value = current_user_id;
                        ws2.Cell(c_col).Value = calc_type;
                        ws2.Cell(d_col).Value = an1;
                        ws2.Cell(e_col).Value = an2;
                        ws2.Cell(f_col).Value = an3;
                        ws2.Cell(g_col).Value = an4;
                        ws2.Cell(h_col).Value = w1;
                        ws2.Cell(i_col).Value = w2;
                        ws2.Cell(j_col).Value = l1;
                        ws2.Cell(k_col).Value = l2;
                        ws2.Cell(l_col).Value = h1;
                        //ws2.Cell(m_col).Value = date;h1;
                        


                        a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                        i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                        q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                        row_count++;
                    }
                }






                a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                row_count = 2;
                var ws3 = wb.Worksheets.Add("Грунтовка, Шпаклевка");
                ws3.Cell("A1").Value = "Id Расчета";
                ws3.Cell("B1").Value = "Id Пользователя";
                ws3.Cell("C1").Value = "кол-во слоев грунтовки";
                ws3.Cell("D1").Value = "вес емкости";
                ws3.Cell("E1").Value = "расход емкости";
                ws3.Cell("F1").Value = "площадь покрытия";
                ws3.Cell("G1").Value = "вес емкостей";
                ws3.Cell("H1").Value = "кол-во емкостей";
                ws3.Cell("I1").Value = "кол-во слоев шпаклевки";
                ws3.Cell("J1").Value = "вес емкости";
                ws3.Cell("K1").Value = "расход емкости";
                ws3.Cell("L1").Value = "площадь покрытия";
                ws3.Cell("M1").Value = "вес емкостей";
                ws3.Cell("N1").Value = "кол-во емкостей";
                //ws2.Cell("M1").Value = "Дата";
                var colu_a3 = ws3.Column("A");
                var colu_b3 = ws3.Column("B");
                var colu_c3 = ws3.Column("C");
                var colu_d3 = ws3.Column("D");
                var colu_e3 = ws3.Column("E");
                var colu_f3 = ws3.Column("F");
                var colu_g3 = ws3.Column("G");
                var colu_h3 = ws3.Column("H");
                var colu_i3 = ws3.Column("I");
                var colu_j3 = ws3.Column("J");
                var colu_k3 = ws3.Column("K");
                var colu_l3 = ws3.Column("L");
                var colu_m3 = ws3.Column("M");
                var colu_n3 = ws3.Column("N");

                var rngTable3 = ws3.Range("A1:N1");
                var rngHeaders3 = rngTable3.Range("A1:N1");
                rngHeaders3.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders3.Style.Font.Bold = true;
                rngHeaders3.Style.Fill.BackgroundColor = XLColor.Aqua;

                var rngtable3 = ws3.Range("A2:W200");
                var rngnumbers3 = rngtable3.Range("A2:W200");
                rngnumbers3.DataType = XLDataType.Number;
                rngnumbers3.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                colu_a3.Width = 9; colu_b3.Width = 14; colu_c3.Width = 20; colu_d3.Width = 11.5; colu_e3.Width = 14; colu_f3.Width = 16.5;
                colu_g3.Width = 12; colu_h3.Width = 15; colu_i3.Width = 22; colu_j3.Width = 11.5; colu_k3.Width = 14; colu_l3.Width = 17;
                colu_m3.Width = 12; colu_n3.Width = 15;


                foreach (materials material in materials)
                {
                    int cur_id2 = material.id;
                    calc_id = cur_id2.ToString();
                    user_id = current_user_id.ToString();
                    calc_type = material.In_grunt_layers;
                    an1 = material.In_grunt_kg_mesh;
                    an2 = material.In_grunt_m_mesh;
                    an3 = material.Grunt_volume_m;
                    an4 = material.Grunt_kg;
                    w1 = material.Grunt_amount;
                    w2 = material.In_ground_coat_thick;
                    l1 = material.In_ground_coat_kg_mesh;
                    l2 = material.In_ground_coat_m_mesh;
                    h1 = material.Ground_coat_volume_m;
                    h2 = material.Ground_coat_volume_kg;
                    h3 = material.Ground_coat_amount;

                    //date = material.Date;
                    int out_id2;
                    //string out_square = "0", out_square2 = "0";


                    if (material.id == cur_id2)
                    {
                        /*wall_square = output.Wall_square;
                        ceiling_perimetr = output.Ceiling_perimetr;
                        ceiling_area = output.Ceiling_area;
                        ground_area = output.Ground_area;
                        ground_perimetr = output.Ground_perimetr;
                        height_length = output.Height_lenght;*/

                        a_col += row_count.ToString();
                        b_col += row_count.ToString();
                        c_col += row_count.ToString();
                        d_col += row_count.ToString();
                        e_col += row_count.ToString();
                        f_col += row_count.ToString();
                        g_col += row_count.ToString();
                        h_col += row_count.ToString();
                        i_col += row_count.ToString();
                        j_col += row_count.ToString();
                        k_col += row_count.ToString();
                        l_col += row_count.ToString();
                        m_col += row_count.ToString();
                        n_col += row_count.ToString();

                        ws3.Cell(a_col).Value = cur_id2;
                        ws3.Cell(b_col).Value = current_user_id;
                        ws3.Cell(c_col).Value = calc_type;
                        ws3.Cell(d_col).Value = an1;
                        ws3.Cell(e_col).Value = an2;
                        ws3.Cell(f_col).Value = an3;
                        ws3.Cell(g_col).Value = an4;
                        ws3.Cell(h_col).Value = w1;
                        ws3.Cell(i_col).Value = w2;
                        ws3.Cell(j_col).Value = l1;
                        ws3.Cell(k_col).Value = l2;
                        ws3.Cell(l_col).Value = h1;
                        ws3.Cell(m_col).Value = h2;
                        ws3.Cell(n_col).Value = h3;
                        


                        a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                        i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                        q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                        row_count++;
                    }
                }






                a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                row_count = 2;
                var ws4 = wb.Worksheets.Add("Краска");
                ws4.Cell("A1").Value = "Id Расчета";
                ws4.Cell("B1").Value = "Id Пользователя";
                ws4.Cell("C1").Value = "кол-во слоев краски";
                ws4.Cell("D1").Value = "вес емкости";
                ws4.Cell("E1").Value = "расход емкости";
                ws4.Cell("F1").Value = "площадь покрытия";
                ws4.Cell("G1").Value = "вес емкостей";
                ws4.Cell("H1").Value = "кол-во емкостей";
                
                //ws2.Cell("M1").Value = "Дата";
                var colu_a4 = ws4.Column("A");
                var colu_b4 = ws4.Column("B");
                var colu_c4 = ws4.Column("C");
                var colu_d4 = ws4.Column("D");
                var colu_e4 = ws4.Column("E");
                var colu_f4 = ws4.Column("F");
                var colu_g4 = ws4.Column("G");
                var colu_h4 = ws4.Column("H");

                var rngtable4 = ws4.Range("A2:W200");
                var rngnumbers4 = rngtable4.Range("A2:W200");
                rngnumbers4.DataType = XLDataType.Number;
                rngnumbers4.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                var rngTable4 = ws4.Range("A1:H1");
                var rngHeaders4 = rngTable4.Range("A1:H1");
                rngHeaders4.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders4.Style.Font.Bold = true;
                rngHeaders4.Style.Fill.BackgroundColor = XLColor.Aqua;


                colu_a4.Width = 9; colu_b4.Width = 14; colu_c4.Width = 20; colu_d4.Width = 11.5; colu_e4.Width = 14; colu_f4.Width = 16.5;
                colu_g4.Width = 12; colu_h4.Width = 15; 


                foreach (materials material in materials)
                {
                    int cur_id2 = material.id;
                    calc_id = cur_id2.ToString();
                    user_id = current_user_id.ToString();
                    calc_type = material.In_paint_layers;
                    an1 = material.In_paint_kg_mesh;
                    an2 = material.In_paint_m_mesh;
                    an3 = material.Paint_volume_m;
                    an4 = material.Paint_kg;
                    w1 = material.Paint_amount;
                   
                    //date = material.Date;
                    int out_id2;
                    //string out_square = "0", out_square2 = "0";


                    if (material.id == cur_id2)
                    {
                        /*wall_square = output.Wall_square;
                        ceiling_perimetr = output.Ceiling_perimetr;
                        ceiling_area = output.Ceiling_area;
                        ground_area = output.Ground_area;
                        ground_perimetr = output.Ground_perimetr;
                        height_length = output.Height_lenght;*/

                        a_col += row_count.ToString();
                        b_col += row_count.ToString();
                        c_col += row_count.ToString();
                        d_col += row_count.ToString();
                        e_col += row_count.ToString();
                        f_col += row_count.ToString();
                        g_col += row_count.ToString();
                        h_col += row_count.ToString();
                        

                        ws4.Cell(a_col).Value = cur_id2;
                        ws4.Cell(b_col).Value = current_user_id;
                        ws4.Cell(c_col).Value = calc_type;
                        ws4.Cell(d_col).Value = an1;
                        ws4.Cell(e_col).Value = an2;
                        ws4.Cell(f_col).Value = an3;
                        ws4.Cell(g_col).Value = an4;
                        ws4.Cell(h_col).Value = w1;
                     



                        a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                        i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                        q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                        row_count++;
                    }
                }
                wb.SaveAs(filePath);
                // Creating a new workbook
                /*var wb = new XLWorkbook();

                //Adding a worksheet
                var ws = wb.Worksheets.Add("Contacts");

                //Adding text
                //Title
                ws.Cell("B2").Value = "Contacts";
                //First Names
                ws.Cell("B3").Value = "FName";
                ws.Cell("B4").Value = "John";
                ws.Cell("B5").Value = "Hank";
                ws.Cell("B6").Value = "Dagny";
                //Last Names
                ws.Cell("C3").Value = "LName";
                ws.Cell("C4").Value = "Galt";
                ws.Cell("C5").Value = "Rearden";
                ws.Cell("C6").Value = "Taggart";

                //Adding more data types
                //Is an outcast?
                ws.Cell("D3").Value = "Outcast";
                ws.Cell("D4").Value = true;
                ws.Cell("D5").Value = false;
                ws.Cell("D6").Value = false;
                //Date of Birth
                ws.Cell("E3").Value = "DOB";
                ws.Cell("E4").Value = new DateTime(1919, 1, 21);
                ws.Cell("E5").Value = new DateTime(1907, 3, 4);
                ws.Cell("E6").Value = new DateTime(1921, 12, 15);
                //Income
                ws.Cell("F3").Value = "Income";
                ws.Cell("F4").Value = 2000;
                ws.Cell("F5").Value = 40000;
                ws.Cell("F6").Value = 10000;

                //Defining ranges
                //From worksheet
                var rngTable = ws.Range("B2:F6");
                //From another range
                var rngDates = rngTable.Range("E4:E6");
                var rngNumbers = rngTable.Range("F4:F6");

                //Formatting dates and numbers
                //Using a OpenXML's predefined formats
                rngDates.Style.NumberFormat.NumberFormatId = 15;
                //Using a custom format
                rngNumbers.Style.NumberFormat.Format = "$ #,##0";

                //Formatting headers
                var rngHeaders = rngTable.Range("B3:F3");
                rngHeaders.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders.Style.Font.Bold = true;
                rngHeaders.Style.Fill.BackgroundColor = XLColor.Aqua;

                //Adding grid lines
                rngTable.Style.Border.BottomBorder = XLBorderStyleValues.Thin;

                //Format title cell
                rngTable.Cell(1, 1).Style.Font.Bold = true;
                rngTable.Cell(1, 1).Style.Fill.BackgroundColor = XLColor.CornflowerBlue;
                rngTable.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                //Merge title cells
                rngTable.Row(1).Merge(); // We could've also used: rngTable.Range("A1:E1").Merge()

                //Add thick borders
                rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thick;

                // You can also specify the border for each side with:
                // rngTable.FirstColumn().Style.Border.LeftBorder = XLBorderStyleValues.Thick;
                // rngTable.LastColumn().Style.Border.RightBorder = XLBorderStyleValues.Thick;
                // rngTable.FirstRow().Style.Border.TopBorder = XLBorderStyleValues.Thick;
                // rngTable.LastRow().Style.Border.BottomBorder = XLBorderStyleValues.Thick;

                // Adjust column widths to their content
                ws.Columns(2, 6).AdjustToContents();

                //Saving the workbook
                */
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Таблица Excel |*.xlsx";
            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    string path2 = saveFileDialog.FileName;
                    Create(path2);

                } catch
                {
                    MessageBox.Show("Ошибка создания файла XSLS");
                }
                MessageBox.Show("Готово");
            }    
        }
        Boolean rooms = false;
        Boolean first_room = true;
        private void add_room_button_Click(object sender, RoutedEventArgs e)
        {
            rooms = true;
            if (first_room)
            {
                first_room = false;
            }
            else
            {
                room_number_export++;
            }
            calculation();
            do_calculation.IsEnabled = false;
        }

        private void finish_button_Click(object sender, RoutedEventArgs e)
        {
            rooms = false;
            room_number_export = 1;
            if (user_type != 3)
            {
                do_calculation.IsEnabled = true;
            }
        }

        // clear all textboxes button
        private void Clear_button_Click(object sender, RoutedEventArgs e)
        {
            space_id = 0;
            space_square = 0;
            all_space_square = 0;
            space_listbox.Items.Clear();
            textblock_paint_result.Text = "";
            width_textbox.Text = "";
            height_textbox.Text = "";
            length_textbox.Text = "";
            height2_textbox.Text = "";
            space_height_textbox.Text = "";
            space_width_textbox.Text = "";
=======
>>>>>>> Stashed changes

            login_textbox.Text = "";
            pass_textbox.Password = "";
            textblock_paint_result.Text = "Выберете \"Тип расчёта\"";
        }
<<<<<<< Updated upstream
        // checkbox spaces in true position
        Boolean space_check_value;
        private void Spaces_check_Checked(object sender, RoutedEventArgs e)
        {
            space_grid.Visibility = Visibility.Visible;
            space_check_value = true;
        }
=======

        
        private void wallpaper_check_Checked(object sender, RoutedEventArgs e)
        {
            check_wall = true;
            wallpapers_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }
        private void wallpaper_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_wall = false;
            wallpapers_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        // 0:31 am fuck
        int grid_number = 2;
        int grids = 0;
        Boolean grid_first = true;
        public void adaptive_epta()
        {
            if (!grid_first)
            {
                //grids += 1;
                while (grids > 0)
                {
                    grid_griddiest.RowDefinitions.RemoveAt(grids);
                    //grid_griddiest.RowDefinitions.Remove(new RowDefinition());
                    grids--;
                }
                
            } else
            {
                grid_first = false;
            }
            if (check_wall)
            {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto } );
                wallpapers_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            }
            if (check_plaster)
            {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                plaster_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            } if (check_grunt)
            {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                grunt_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            } if (check_ground_coat) {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                ground_coat_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            } if (check_paint)
            {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                paint_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            }
            grid_number = 2;

        }

        Boolean first_here = true;
        Boolean check_wall = false;
        Boolean check_plaster = false;
        Boolean check_grunt = false;
        Boolean check_ground_coat = false;
        Boolean check_paint = false;

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
           new _3d_model(width1, length1, height1, height1, height1).ShowDialog();
        }

        //profile updater
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
          /*  login_info_textbox.Text = null;
            mail_info_textbox.Text = null;
            pass_info_textbox.Text = null;
            pass2_info_textbox.Text = null;*/

            string login_update = update_login.Text.Trim();
            string mail_update = update_email.Text.Trim().ToLower();
            string pass1_update = update_pass1.Password.Trim();
            string pass2_update = update_pass2.Password.Trim();

            mail_update = (mail_update == "") ? mail_update = null : mail_update = mail_update;
            pass1_update = (pass1_update == "") ? pass1_update = null : pass1_update = pass1_update;
            pass2_update = (pass2_update == "") ? pass2_update = null : pass2_update = pass2_update;

            if (mail_update != null || pass1_update != null || pass2_update != null)
            {
                update_email.Text = null;
                
                var md5 = MD5.Create();
                string pass_md5 = "300$";
                try
                {
                    md5 = MD5.Create();
                    pass_md5 = Convert.ToBase64String(md5.ComputeHash(Encoding.UTF8.GetBytes(pass1_update)));
                }
                catch
                {
                    MessageBox.Show("Ошибка с MD5");
                }
                user login_check;
                using (ApplicationContext db = new ApplicationContext())
                {
                    login_check = db.users.Where(b => b.Login == profile_user_login).FirstOrDefault();
                }
                user updating = null;





                if (pass1_update != pass2_update)
                {
                    update_pass1.ToolTip = "Пароли не совпадают";
                    update_pass1.BorderBrush = Brushes.Crimson;
                    update_pass2.ToolTip = "Пароли не совпадают";
                    update_pass2.BorderBrush = Brushes.Crimson;

                }
                else if (pass2_update.Length < 4 && pass1_update.Length < 4)
                {

                    update_pass1.ToolTip = "Длина пароля должна быть больше 4 символов";
                    update_pass2.ToolTip = "Длина пароля должна быть больше 4 символов";
                    update_pass1.BorderBrush = Brushes.Crimson;
                    update_pass2.BorderBrush = Brushes.Crimson;
                } else if (pass1_update != null && pass2_update != null)
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        updating = db.users.Where(b => b.Login == profile_user_login).FirstOrDefault();
                        updating.Password = pass_md5;
                        db.SaveChanges();

                    }

                    MessageBox.Show("Пароль изменен");
                    MessageBox.Show(update_pass1.ToString());
                    update_pass1.ToolTip = null;
                    update_pass1.BorderBrush = Brushes.Black;
                    update_pass2.BorderBrush = Brushes.Black;
                    update_pass2.ToolTip = null;
                    update_pass1.Password = null;
                    update_pass2.Password = null;
                }


                if (mail_update.Length < 5)
                {
                    update_email.ToolTip = "Длина почты должна быть больше 5 символов";
                    update_email.BorderBrush = Brushes.Crimson;
                }
                else
                {
                    update_email.ToolTip = null;
                    update_email.BorderBrush = Brushes.Black;
                }


                if (!mail_update.Contains('@') || !mail_update.Contains('.'))
                {
                    update_email.ToolTip = "Почта введена неправильно";
                    update_email.BorderBrush = Brushes.Crimson;
                }
                else if (mail_update.Length < 5)
                {
                    update_email.ToolTip = "Длина почты должна быть больше 5 символов";
                }
                else
                {
                    if (updating != null)
                    {
                        updating.Email = mail_update;
                    }
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        updating = db.users.Where(b => b.Login == profile_user_login).FirstOrDefault();
                        updating.Email = mail_update;
                        db.SaveChanges();
                    }
                    
                    MessageBox.Show("Почта изменена");
                    update_email.ToolTip = null;
                    update_email.BorderBrush = Brushes.Black;

                }


                
                } else
                {
                MessageBox.Show("Ничего не изменилось 🤨");
                }
        }

        private void plaster_check_Checked(object sender, RoutedEventArgs e)
        {
            check_plaster = true;
            plaster_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }

        private void plaster_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_plaster = false;
            plaster_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        private void grunt_check_Checked(object sender, RoutedEventArgs e)
        {
            check_grunt = true;
            grunt_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }

        private void grunt_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_grunt = false;
            grunt_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        private void ground_coat_check_Checked(object sender, RoutedEventArgs e)
        {
            check_ground_coat = true;
            ground_coat_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }

        private void ground_coat_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_ground_coat = false;
            ground_coat_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        private void paint_check_Checked(object sender, RoutedEventArgs e)
        {
            check_paint = true;
            paint_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }

        private void paint_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_paint = false;
            paint_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        int type_calc_check = 0;
        //when type of calc changed
        private void Paint_calcs_combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            selected_type_of_calc = Convert.ToByte(paint_calcs_combobox.SelectedIndex + 1);
            //MessageBox.Show(selected_type_of_calc.ToString());
            //Thickness space_margin = space_grid.Margin;
            textblock_paint_result.Text = "Нажмите \"Рассчитать\"";
            switch (selected_type_of_calc)
            {
                case 1:
                    //space_grid.Margin = new Thickness(0, 300, 0, 0);
                    //textblock_paint_result.Margin = new Thickness(0, 115, 0, 0);
                    spaces_top = 100;
                    height2_grid.Visibility = Visibility.Hidden;
                    height3_grid.Visibility = Visibility.Hidden;
                    height4_grid.Visibility = Visibility.Hidden;
                    type_calc_check = 1;
                    if (first_here)
                    {
                        do_calculation.IsEnabled = true;
                    } else if (rooms) {
                        do_calculation.IsEnabled = false;
                    }
                    if (user_type != 3 && first_here || rooms) add_room_button.IsEnabled = true; 
                    else
                        add_room_button.IsEnabled = false;
                    first_here = false;
                    break;
                case 2:
                    type_calc_check = 2;
                    //space_grid.Margin = new Thickness(0, 345, 0, 0);
                    //textblock_paint_result.Margin = new Thickness(0, 160, 0, 0);
                    height2_grid.Visibility = Visibility.Visible;
                    height3_grid.Visibility = Visibility.Hidden;
                    height4_grid.Visibility = Visibility.Hidden;
                    spaces_top = 170;

                    if (first_here)
                    {
                        do_calculation.IsEnabled = true;
                    }
                    else if (rooms)
                    {
                        do_calculation.IsEnabled = false;
                    }
                    if (user_type != 3 && first_here || rooms) add_room_button.IsEnabled = true;
                    else
                        add_room_button.IsEnabled = false;
                    first_here = false;
                    break;
                case 3:
                    type_calc_check = 3;
                    height2_grid.Visibility = Visibility.Visible;
                    height3_grid.Visibility = Visibility.Visible;
                    height4_grid.Visibility = Visibility.Visible;
                    spaces_top = 170;
                    if (first_here)
                    {
                        do_calculation.IsEnabled = true;
                    }
                    else if (rooms)
                    {
                        do_calculation.IsEnabled = false;
                    }
                    if (user_type != 3 && first_here || rooms) add_room_button.IsEnabled = true;
                    else
                        add_room_button.IsEnabled = false;
                    first_here = false;
                    break;
                /*case 4:
                    type_calc_check = 4;
                    if (first_here)
                    {
                        do_calculation.IsEnabled = true;
                    }
                    else if (rooms)
                    {
                        do_calculation.IsEnabled = false;
                    }
                    if (user_type != 3 && first_here || rooms) add_room_button.IsEnabled = true;
                    else
                        add_room_button.IsEnabled = false;
                    first_here = false;
                    break;*/
            }
            space_grid.Margin = new Thickness(0, spaces_top, 190, 4);
        }
        // add space button
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            space_width = check_value(space_width_textbox.Text);
            space_height = check_value(space_height_textbox.Text);
            if (space_height > 0 && space_width > 0)
            {
                space_id++;
                space_square = space_width * space_height;
                space_listbox.Items.Add("Проем №" + space_id + ", Ширина - " + space_width + ", Высота - " + space_height + ", Площадь - " + space_square + " - " + measure_ln + "\u00B2");
                all_space_square += space_square;
            } else
            {
                warning_number_window();
            }
        }


        private void Space_history_listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Account_info_btn_Click(object sender, RoutedEventArgs e)
        {
            hide_profile(0);
            hide_menu2(1);
            update_login.Text = profile_user_login;
            update_email.Text = profile_user_mail;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void history_button_Click(object sender, RoutedEventArgs e)
        {
            admin_grid.Visibility = Visibility.Visible;
            hide_menu2(1);
            users_list_update();
        }

        private void delete_user_button_Click(object sender, RoutedEventArgs e)
        {
            var a = Int32.TryParse(deleted_user_id_textbox.Text.ToString(), out int value_1);
            if (a)
            {
                int delete_id = Math.Abs(Int32.Parse(deleted_user_id_textbox.Text.ToString()));
                user admin_stat = null;
                using (ApplicationContext db = new ApplicationContext())
                {
                    admin_stat = db.users.Where(b => b.id == delete_id).FirstOrDefault();
                }
                try
                {
                    if (admin_stat != null)
                    {

                        if (admin_stat.Admin_status != "true")
                        {
                            try
                            {
                                var input_del = db.users.FirstOrDefault(x => x.id == delete_id);
                                db.users.Remove(input_del);
                                db.SaveChanges();
                                users_list_update();
                            }
                            catch
                            {

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка");
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
            else
            {
                warning_number_window();
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            void Create(string filePath)
            {
                string calc_id, user_id, calc_type, an1, an2, an3, an4, w1, w2, l1, l2, h1, h2, h3, h4, space_square, date;
                string wall_square, ceiling_perimetr, ceiling_area, ground_area, ground_perimetr, height_length;
                List<input_paints> inputs;
                List<output_paints> outputs;
                List<materials> materials;
                if (user_type == 2)
                {
                    inputs = db.input_paint.ToList();
                    outputs = db.output_paint.ToList();
                    materials = db.material.ToList();
                }
                else
                {
                    inputs = db.input_paint.Where(b => b.User_id == current_user_id.ToString()).ToList();
                    outputs = db.output_paint.Where(b => b.User_id == current_user_id.ToString()).ToList();
                    materials = db.material.Where(b => b.User_id == current_user_id.ToString()).ToList();
                }

                string a_col = "A", b_col = "B", c_col = "C", d_col = "D", e_col = "E", f_col = "F", g_col = "G", h_col = "H";
                string i_col = "I", j_col = "J", k_col = "K", l_col = "L", m_col = "M", n_col = "N", o_col = "O", p_col = "P";
                string q_col = "Q", r_col = "R", s_col = "S", t_col = "T", u_col = "U", v_col = "V", w_col = "W", x_col = "X";
                int row_count = 2;

                var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add("Расчёты");

                var colu_a1 = ws.Column("A");
                var colu_b1 = ws.Column("B");
                var colu_c1 = ws.Column("C");
                var colu_d1 = ws.Column("D");
                var colu_e1 = ws.Column("E");
                var colu_f1 = ws.Column("F");
                var colu_g1 = ws.Column("G");
                var colu_h1 = ws.Column("H");
                var colu_i1 = ws.Column("I");
                var colu_j1 = ws.Column("J");
                var colu_k1 = ws.Column("K");
                var colu_l1 = ws.Column("L");
                var colu_m1 = ws.Column("M");
                var colu_n1 = ws.Column("N");
                var colu_o1 = ws.Column("O");
                var colu_p1 = ws.Column("P");
                var colu_q1 = ws.Column("Q");
                var colu_r1 = ws.Column("R");
                var colu_s1 = ws.Column("S");
                var colu_t1 = ws.Column("T");
                var colu_u1 = ws.Column("U");
                var colu_v1 = ws.Column("V");
                var colu_w1 = ws.Column("W");
                var colu_x1 = ws.Column("X");



                colu_a1.Width = 9; colu_b1.Width = 15; colu_c1.Width = 11; colu_d1.Width = 9; colu_e1.Width = 9; colu_f1.Width = 9;
                colu_g1.Width = 9; colu_h1.Width = 11; colu_i1.Width = 11; colu_j1.Width = 11; colu_k1.Width = 11; colu_l1.Width = 11;
                colu_m1.Width = 11; colu_n1.Width = 11; colu_o1.Width = 11; colu_p1.Width = 11; colu_q1.Width = 17;
                colu_r1.Width = 17; colu_s1.Width = 13; colu_t1.Width = 14; colu_u1.Width = 17; colu_v1.Width = 24; colu_w1.Width = 20; colu_x1.Width = 20;

                var rngTable1 = ws.Range("A1:X1");
                var rngHeaders1 = rngTable1.Range("A1:X1");
                rngHeaders1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders1.Style.Font.Bold = true;
                rngHeaders1.Style.Fill.BackgroundColor = XLColor.Aqua;

                var rngtable1 = ws.Range("A2:X200");
                var rngnumbers1 = rngtable1.Range("A2:X200");
                rngnumbers1.DataType = XLDataType.Number;
                rngnumbers1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                ws.Cell("A1").Value = "Id Расчета";
                ws.Cell("B1").Value = "Id Пользователя";
                ws.Cell("C1").Value = "Тип расчёта";
                ws.Cell("D1").Value = "Угол №1";
                ws.Cell("E1").Value = "Угол №2";
                ws.Cell("F1").Value = "Угол №3";
                ws.Cell("G1").Value = "Угол №4";
                ws.Cell("H1").Value = "Ширнина №1";
                ws.Cell("I1").Value = "Ширнина №2";
                ws.Cell("J1").Value = "Длина №1";
                ws.Cell("K1").Value = "Длина №2";
                ws.Cell("L1").Value = "Высота №1";
                ws.Cell("M1").Value = "Высота №2";
                ws.Cell("N1").Value = "Высота №3";
                ws.Cell("O1").Value = "Высота №4";
                ws.Cell("P1").Value = "Площадь стен";
                ws.Cell("Q1").Value = "Периметр потолка";
                ws.Cell("R1").Value = "Площадь потолка";
                ws.Cell("S1").Value = "Площадь пола";
                ws.Cell("T1").Value = "Периметр пола";
                ws.Cell("U1").Value = "Площадь проемов";
                ws.Cell("V1").Value = "Общая высота всех углов";
                ws.Cell("W1").Value = "Дата";
                ws.Cell("X1").Value = "Номер комнаты";


                foreach (input_paints input in inputs)
                {
                    int cur_id = input.id;
                    calc_id = cur_id.ToString();
                    user_id = current_user_id.ToString();
                    calc_type = input.Calc_type;
                    an1 = input.An1;
                    an2 = input.An2;
                    an3 = input.An3;
                    an4 = input.An4;
                    w1 = input.W1;
                    w2 = input.W2;
                    l1 = input.L1;
                    l2 = input.L2;
                    h1 = input.H1;
                    h2 = input.H2;
                    h3 = input.H3;
                    h4 = input.H4;
                    string h5 = input.Room_number;
                    space_square = input.Space_square;
                    date = input.Date;
                    int out_id;
                    string out_square = "0", out_square2 = "0";
                    foreach (output_paints output in outputs)
                    {

                        if (output.id == cur_id)
                        {
                            wall_square = output.Wall_square;
                            ceiling_perimetr = output.Ceiling_perimetr;
                            ceiling_area = output.Ceiling_area;
                            ground_area = output.Ground_area;
                            ground_perimetr = output.Ground_perimetr;
                            height_length = output.Height_lenght;

                            a_col += row_count.ToString();
                            b_col += row_count.ToString();
                            c_col += row_count.ToString();
                            d_col += row_count.ToString();
                            e_col += row_count.ToString();
                            f_col += row_count.ToString();
                            g_col += row_count.ToString();
                            h_col += row_count.ToString();
                            i_col += row_count.ToString();
                            j_col += row_count.ToString();
                            k_col += row_count.ToString();
                            l_col += row_count.ToString();
                            m_col += row_count.ToString();
                            n_col += row_count.ToString();
                            o_col += row_count.ToString();
                            p_col += row_count.ToString();
                            q_col += row_count.ToString();
                            r_col += row_count.ToString();
                            s_col += row_count.ToString();
                            t_col += row_count.ToString();
                            u_col += row_count.ToString();
                            v_col += row_count.ToString();
                            w_col += row_count.ToString();
                            x_col += row_count.ToString();

                            ws.Cell(a_col).Value = cur_id;
                            ws.Cell(b_col).Value = current_user_id;
                            ws.Cell(c_col).Value = calc_type;
                            ws.Cell(d_col).Value = an1;
                            ws.Cell(e_col).Value = an2;
                            ws.Cell(f_col).Value = an3;
                            ws.Cell(g_col).Value = an4;
                            ws.Cell(h_col).Value = w1;
                            ws.Cell(i_col).Value = w2;
                            ws.Cell(j_col).Value = l1;
                            ws.Cell(k_col).Value = l2;
                            ws.Cell(l_col).Value = h1;
                            ws.Cell(m_col).Value = h2;
                            ws.Cell(n_col).Value = h3;
                            ws.Cell(o_col).Value = h4;
                            ws.Cell(p_col).Value = wall_square;
                            ws.Cell(q_col).Value = ceiling_perimetr;
                            ws.Cell(r_col).Value = ceiling_area;
                            ws.Cell(s_col).Value = ground_area;
                            ws.Cell(t_col).Value = ground_perimetr;
                            ws.Cell(u_col).Value = space_square;
                            ws.Cell(v_col).Value = height_length;
                            ws.Cell(w_col).Value = date;
                            ws.Cell(x_col).Value = h5;
                            a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                            i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                            q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                            row_count++;
                        }
                    }

                    
                }
                a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                row_count = 2;
                var ws2 = wb.Worksheets.Add("Обои, Штукатурка");
                ws2.Cell("A1").Value = "Id Расчета";
                ws2.Cell("B1").Value = "Id Пользователя";
                ws2.Cell("C1").Value = "Ширина обоев";
                ws2.Cell("D1").Value = "Ширина рулона";
                ws2.Cell("E1").Value = "Длина обоев";
                ws2.Cell("F1").Value = "Кол-во рулонов";
                ws2.Cell("G1").Value = "Кол-во слоев штукатурки";
                ws2.Cell("H1").Value = "Вес емкости штукатурки";
                ws2.Cell("I1").Value = "Расход емкости";
                ws2.Cell("J1").Value = "Площадь расхода";
                ws2.Cell("K1").Value = "Вес емкостей";
                ws2.Cell("L1").Value = "Кол-во емкостей";
                //ws2.Cell("M1").Value = "Дата";
                var colu_a = ws2.Column("A");
                var colu_b = ws2.Column("B");
                var colu_c = ws2.Column("C");
                var colu_d = ws2.Column("D");
                var colu_e = ws2.Column("E");
                var colu_f = ws2.Column("F");
                var colu_g = ws2.Column("G");
                var colu_h = ws2.Column("H");
                var colu_i = ws2.Column("I");
                var colu_j = ws2.Column("J");
                var colu_k = ws2.Column("K");
                var colu_l = ws2.Column("L");

                var rngTable2 = ws2.Range("A1:L1");
                var rngHeaders2 = rngTable2.Range("A1:L1");
                rngHeaders2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders2.Style.Font.Bold = true;
                rngHeaders2.Style.Fill.BackgroundColor = XLColor.Aqua;

                var rngtable2 = ws2.Range("A2:W200");
                var rngnumbers2 = rngtable2.Range("A2:W200");
                rngnumbers2.DataType = XLDataType.Number;
                rngnumbers2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                colu_a.Width = 9; colu_b.Width = 14; colu_c.Width = 13; colu_d.Width = 13.5; colu_e.Width = 11; colu_f.Width = 13.5;
                colu_g.Width = 21.5; colu_h.Width = 20; colu_i.Width = 13.5; colu_j.Width = 15.3; colu_k.Width = 12; colu_l.Width = 15;


                foreach (materials material in materials)
                {
                    int cur_id2 = material.id;
                    calc_id = cur_id2.ToString();
                    user_id = current_user_id.ToString();
                    calc_type = material.In_wallpapers_width;
                    an1 = material.In_wallpapers_circle_length;
                    an2 = material.Wallpapers_length_m;
                    an3 = material.Wallpapers_amount;
                    an4 = material.In_plaster_thick;
                    w1 = material.In_plaster_kg_mesh;
                    w2 = material.In_plaster_m_mesh;
                    l1 = material.Plaster_volume_m;
                    l2 = material.Plaster_kg;
                    h1 = material.Plaster_amount;
                    //date = material.Date;
                    int out_id2;
                    //string out_square = "0", out_square2 = "0";


                    if (material.id == cur_id2)
                    {
                        /*wall_square = output.Wall_square;
                        ceiling_perimetr = output.Ceiling_perimetr;
                        ceiling_area = output.Ceiling_area;
                        ground_area = output.Ground_area;
                        ground_perimetr = output.Ground_perimetr;
                        height_length = output.Height_lenght;*/

                        a_col += row_count.ToString();
                        b_col += row_count.ToString();
                        c_col += row_count.ToString();
                        d_col += row_count.ToString();
                        e_col += row_count.ToString();
                        f_col += row_count.ToString();
                        g_col += row_count.ToString();
                        h_col += row_count.ToString();
                        i_col += row_count.ToString();
                        j_col += row_count.ToString();
                        k_col += row_count.ToString();
                        l_col += row_count.ToString();
                        //m_col += row_count.ToString();


                        ws2.Cell(a_col).Value = cur_id2;
                        ws2.Cell(b_col).Value = current_user_id;
                        ws2.Cell(c_col).Value = calc_type;
                        ws2.Cell(d_col).Value = an1;
                        ws2.Cell(e_col).Value = an2;
                        ws2.Cell(f_col).Value = an3;
                        ws2.Cell(g_col).Value = an4;
                        ws2.Cell(h_col).Value = w1;
                        ws2.Cell(i_col).Value = w2;
                        ws2.Cell(j_col).Value = l1;
                        ws2.Cell(k_col).Value = l2;
                        ws2.Cell(l_col).Value = h1;
                        //ws2.Cell(m_col).Value = date;h1;
                        


                        a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                        i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                        q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                        row_count++;
                    }
                }






                a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                row_count = 2;
                var ws3 = wb.Worksheets.Add("Грунтовка, Шпаклевка");
                ws3.Cell("A1").Value = "Id Расчета";
                ws3.Cell("B1").Value = "Id Пользователя";
                ws3.Cell("C1").Value = "кол-во слоев грунтовки";
                ws3.Cell("D1").Value = "вес емкости";
                ws3.Cell("E1").Value = "расход емкости";
                ws3.Cell("F1").Value = "площадь покрытия";
                ws3.Cell("G1").Value = "вес емкостей";
                ws3.Cell("H1").Value = "кол-во емкостей";
                ws3.Cell("I1").Value = "кол-во слоев шпаклевки";
                ws3.Cell("J1").Value = "вес емкости";
                ws3.Cell("K1").Value = "расход емкости";
                ws3.Cell("L1").Value = "площадь покрытия";
                ws3.Cell("M1").Value = "вес емкостей";
                ws3.Cell("N1").Value = "кол-во емкостей";
                //ws2.Cell("M1").Value = "Дата";
                var colu_a3 = ws3.Column("A");
                var colu_b3 = ws3.Column("B");
                var colu_c3 = ws3.Column("C");
                var colu_d3 = ws3.Column("D");
                var colu_e3 = ws3.Column("E");
                var colu_f3 = ws3.Column("F");
                var colu_g3 = ws3.Column("G");
                var colu_h3 = ws3.Column("H");
                var colu_i3 = ws3.Column("I");
                var colu_j3 = ws3.Column("J");
                var colu_k3 = ws3.Column("K");
                var colu_l3 = ws3.Column("L");
                var colu_m3 = ws3.Column("M");
                var colu_n3 = ws3.Column("N");

                var rngTable3 = ws3.Range("A1:N1");
                var rngHeaders3 = rngTable3.Range("A1:N1");
                rngHeaders3.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders3.Style.Font.Bold = true;
                rngHeaders3.Style.Fill.BackgroundColor = XLColor.Aqua;

                var rngtable3 = ws3.Range("A2:W200");
                var rngnumbers3 = rngtable3.Range("A2:W200");
                rngnumbers3.DataType = XLDataType.Number;
                rngnumbers3.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                colu_a3.Width = 9; colu_b3.Width = 14; colu_c3.Width = 20; colu_d3.Width = 11.5; colu_e3.Width = 14; colu_f3.Width = 16.5;
                colu_g3.Width = 12; colu_h3.Width = 15; colu_i3.Width = 22; colu_j3.Width = 11.5; colu_k3.Width = 14; colu_l3.Width = 17;
                colu_m3.Width = 12; colu_n3.Width = 15;


                foreach (materials material in materials)
                {
                    int cur_id2 = material.id;
                    calc_id = cur_id2.ToString();
                    user_id = current_user_id.ToString();
                    calc_type = material.In_grunt_layers;
                    an1 = material.In_grunt_kg_mesh;
                    an2 = material.In_grunt_m_mesh;
                    an3 = material.Grunt_volume_m;
                    an4 = material.Grunt_kg;
                    w1 = material.Grunt_amount;
                    w2 = material.In_ground_coat_thick;
                    l1 = material.In_ground_coat_kg_mesh;
                    l2 = material.In_ground_coat_m_mesh;
                    h1 = material.Ground_coat_volume_m;
                    h2 = material.Ground_coat_volume_kg;
                    h3 = material.Ground_coat_amount;

                    //date = material.Date;
                    int out_id2;
                    //string out_square = "0", out_square2 = "0";


                    if (material.id == cur_id2)
                    {
                        /*wall_square = output.Wall_square;
                        ceiling_perimetr = output.Ceiling_perimetr;
                        ceiling_area = output.Ceiling_area;
                        ground_area = output.Ground_area;
                        ground_perimetr = output.Ground_perimetr;
                        height_length = output.Height_lenght;*/

                        a_col += row_count.ToString();
                        b_col += row_count.ToString();
                        c_col += row_count.ToString();
                        d_col += row_count.ToString();
                        e_col += row_count.ToString();
                        f_col += row_count.ToString();
                        g_col += row_count.ToString();
                        h_col += row_count.ToString();
                        i_col += row_count.ToString();
                        j_col += row_count.ToString();
                        k_col += row_count.ToString();
                        l_col += row_count.ToString();
                        m_col += row_count.ToString();
                        n_col += row_count.ToString();

                        ws3.Cell(a_col).Value = cur_id2;
                        ws3.Cell(b_col).Value = current_user_id;
                        ws3.Cell(c_col).Value = calc_type;
                        ws3.Cell(d_col).Value = an1;
                        ws3.Cell(e_col).Value = an2;
                        ws3.Cell(f_col).Value = an3;
                        ws3.Cell(g_col).Value = an4;
                        ws3.Cell(h_col).Value = w1;
                        ws3.Cell(i_col).Value = w2;
                        ws3.Cell(j_col).Value = l1;
                        ws3.Cell(k_col).Value = l2;
                        ws3.Cell(l_col).Value = h1;
                        ws3.Cell(m_col).Value = h2;
                        ws3.Cell(n_col).Value = h3;
                        


                        a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                        i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                        q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                        row_count++;
                    }
                }






                a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                row_count = 2;
                var ws4 = wb.Worksheets.Add("Краска");
                ws4.Cell("A1").Value = "Id Расчета";
                ws4.Cell("B1").Value = "Id Пользователя";
                ws4.Cell("C1").Value = "кол-во слоев краски";
                ws4.Cell("D1").Value = "вес емкости";
                ws4.Cell("E1").Value = "расход емкости";
                ws4.Cell("F1").Value = "площадь покрытия";
                ws4.Cell("G1").Value = "вес емкостей";
                ws4.Cell("H1").Value = "кол-во емкостей";
                
                //ws2.Cell("M1").Value = "Дата";
                var colu_a4 = ws4.Column("A");
                var colu_b4 = ws4.Column("B");
                var colu_c4 = ws4.Column("C");
                var colu_d4 = ws4.Column("D");
                var colu_e4 = ws4.Column("E");
                var colu_f4 = ws4.Column("F");
                var colu_g4 = ws4.Column("G");
                var colu_h4 = ws4.Column("H");

                var rngtable4 = ws4.Range("A2:W200");
                var rngnumbers4 = rngtable4.Range("A2:W200");
                rngnumbers4.DataType = XLDataType.Number;
                rngnumbers4.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                var rngTable4 = ws4.Range("A1:H1");
                var rngHeaders4 = rngTable4.Range("A1:H1");
                rngHeaders4.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders4.Style.Font.Bold = true;
                rngHeaders4.Style.Fill.BackgroundColor = XLColor.Aqua;


                colu_a4.Width = 9; colu_b4.Width = 14; colu_c4.Width = 20; colu_d4.Width = 11.5; colu_e4.Width = 14; colu_f4.Width = 16.5;
                colu_g4.Width = 12; colu_h4.Width = 15; 


                foreach (materials material in materials)
                {
                    int cur_id2 = material.id;
                    calc_id = cur_id2.ToString();
                    user_id = current_user_id.ToString();
                    calc_type = material.In_paint_layers;
                    an1 = material.In_paint_kg_mesh;
                    an2 = material.In_paint_m_mesh;
                    an3 = material.Paint_volume_m;
                    an4 = material.Paint_kg;
                    w1 = material.Paint_amount;
                   
                    //date = material.Date;
                    int out_id2;
                    //string out_square = "0", out_square2 = "0";


                    if (material.id == cur_id2)
                    {
                        /*wall_square = output.Wall_square;
                        ceiling_perimetr = output.Ceiling_perimetr;
                        ceiling_area = output.Ceiling_area;
                        ground_area = output.Ground_area;
                        ground_perimetr = output.Ground_perimetr;
                        height_length = output.Height_lenght;*/

                        a_col += row_count.ToString();
                        b_col += row_count.ToString();
                        c_col += row_count.ToString();
                        d_col += row_count.ToString();
                        e_col += row_count.ToString();
                        f_col += row_count.ToString();
                        g_col += row_count.ToString();
                        h_col += row_count.ToString();
                        

                        ws4.Cell(a_col).Value = cur_id2;
                        ws4.Cell(b_col).Value = current_user_id;
                        ws4.Cell(c_col).Value = calc_type;
                        ws4.Cell(d_col).Value = an1;
                        ws4.Cell(e_col).Value = an2;
                        ws4.Cell(f_col).Value = an3;
                        ws4.Cell(g_col).Value = an4;
                        ws4.Cell(h_col).Value = w1;
                     



                        a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                        i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                        q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                        row_count++;
                    }
                }
                wb.SaveAs(filePath);
                // Creating a new workbook
                /*var wb = new XLWorkbook();

                //Adding a worksheet
                var ws = wb.Worksheets.Add("Contacts");

                //Adding text
                //Title
                ws.Cell("B2").Value = "Contacts";
                //First Names
                ws.Cell("B3").Value = "FName";
                ws.Cell("B4").Value = "John";
                ws.Cell("B5").Value = "Hank";
                ws.Cell("B6").Value = "Dagny";
                //Last Names
                ws.Cell("C3").Value = "LName";
                ws.Cell("C4").Value = "Galt";
                ws.Cell("C5").Value = "Rearden";
                ws.Cell("C6").Value = "Taggart";

                //Adding more data types
                //Is an outcast?
                ws.Cell("D3").Value = "Outcast";
                ws.Cell("D4").Value = true;
                ws.Cell("D5").Value = false;
                ws.Cell("D6").Value = false;
                //Date of Birth
                ws.Cell("E3").Value = "DOB";
                ws.Cell("E4").Value = new DateTime(1919, 1, 21);
                ws.Cell("E5").Value = new DateTime(1907, 3, 4);
                ws.Cell("E6").Value = new DateTime(1921, 12, 15);
                //Income
                ws.Cell("F3").Value = "Income";
                ws.Cell("F4").Value = 2000;
                ws.Cell("F5").Value = 40000;
                ws.Cell("F6").Value = 10000;

                //Defining ranges
                //From worksheet
                var rngTable = ws.Range("B2:F6");
                //From another range
                var rngDates = rngTable.Range("E4:E6");
                var rngNumbers = rngTable.Range("F4:F6");

                //Formatting dates and numbers
                //Using a OpenXML's predefined formats
                rngDates.Style.NumberFormat.NumberFormatId = 15;
                //Using a custom format
                rngNumbers.Style.NumberFormat.Format = "$ #,##0";

                //Formatting headers
                var rngHeaders = rngTable.Range("B3:F3");
                rngHeaders.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders.Style.Font.Bold = true;
                rngHeaders.Style.Fill.BackgroundColor = XLColor.Aqua;

                //Adding grid lines
                rngTable.Style.Border.BottomBorder = XLBorderStyleValues.Thin;

                //Format title cell
                rngTable.Cell(1, 1).Style.Font.Bold = true;
                rngTable.Cell(1, 1).Style.Fill.BackgroundColor = XLColor.CornflowerBlue;
                rngTable.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                //Merge title cells
                rngTable.Row(1).Merge(); // We could've also used: rngTable.Range("A1:E1").Merge()

                //Add thick borders
                rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thick;

                // You can also specify the border for each side with:
                // rngTable.FirstColumn().Style.Border.LeftBorder = XLBorderStyleValues.Thick;
                // rngTable.LastColumn().Style.Border.RightBorder = XLBorderStyleValues.Thick;
                // rngTable.FirstRow().Style.Border.TopBorder = XLBorderStyleValues.Thick;
                // rngTable.LastRow().Style.Border.BottomBorder = XLBorderStyleValues.Thick;

                // Adjust column widths to their content
                ws.Columns(2, 6).AdjustToContents();

                //Saving the workbook
                */
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Таблица Excel |*.xlsx";
            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    string path2 = saveFileDialog.FileName;
                    Create(path2);

                } catch
                {
                    MessageBox.Show("Ошибка создания файла XSLS");
                }
                MessageBox.Show("Готово");
            }    
        }
        Boolean rooms = false;
        Boolean first_room = true;
        private void add_room_button_Click(object sender, RoutedEventArgs e)
        {
            rooms = true;
            if (first_room)
            {
                first_room = false;
            }
            else
            {
                room_number_export++;
            }
            calculation();
            do_calculation.IsEnabled = false;
        }

        private void finish_button_Click(object sender, RoutedEventArgs e)
        {
            rooms = false;
            room_number_export = 1;
            if (user_type != 3)
            {
                do_calculation.IsEnabled = true;
            }
        }

        // clear all textboxes button
        private void Clear_button_Click(object sender, RoutedEventArgs e)
        {
            space_id = 0;
            space_square = 0;
            all_space_square = 0;
            space_listbox.Items.Clear();
            textblock_paint_result.Text = "";
            width_textbox.Text = "";
            height_textbox.Text = "";
            length_textbox.Text = "";
            height2_textbox.Text = "";
            space_height_textbox.Text = "";
            space_width_textbox.Text = "";
=======

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            grid_menu.Visibility = Visibility.Visible;
            main_menu_grid.Visibility = Visibility.Hidden;
            history_button.IsEnabled = false;
            history_btn.IsEnabled = false;
            add_room_button.IsEnabled = false;
            account_info_btn.IsEnabled = false;
            user_type = 3;
>>>>>>> Stashed changes

            login_textbox.Text = "";
            pass_textbox.Password = "";
            textblock_paint_result.Text = "Выберете \"Тип расчёта\"";
        }
<<<<<<< Updated upstream
        // checkbox spaces in true position
        Boolean space_check_value;
        private void Spaces_check_Checked(object sender, RoutedEventArgs e)
        {
            space_grid.Visibility = Visibility.Visible;
            space_check_value = true;
        }
>>>>>>> Stashed changes
=======

        
        private void wallpaper_check_Checked(object sender, RoutedEventArgs e)
        {
            check_wall = true;
            wallpapers_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }
        private void wallpaper_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_wall = false;
            wallpapers_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        // 0:31 am fuck
        int grid_number = 2;
        int grids = 0;
        Boolean grid_first = true;
        public void adaptive_epta()
        {
            if (!grid_first)
            {
                //grids += 1;
                while (grids > 0)
                {
                    grid_griddiest.RowDefinitions.RemoveAt(grids);
                    //grid_griddiest.RowDefinitions.Remove(new RowDefinition());
                    grids--;
                }
                
            } else
            {
                grid_first = false;
            }
            if (check_wall)
            {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto } );
                wallpapers_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            }
            if (check_plaster)
            {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                plaster_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            } if (check_grunt)
            {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                grunt_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            } if (check_ground_coat) {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                ground_coat_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            } if (check_paint)
            {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                paint_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            }
            grid_number = 2;

        }

        Boolean first_here = true;
        Boolean check_wall = false;
        Boolean check_plaster = false;
        Boolean check_grunt = false;
        Boolean check_ground_coat = false;
        Boolean check_paint = false;

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
           new _3d_model(width1, length1, height1, height1, height1).ShowDialog();
        }

        //profile updater
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
          /*  login_info_textbox.Text = null;
            mail_info_textbox.Text = null;
            pass_info_textbox.Text = null;
            pass2_info_textbox.Text = null;*/

            string login_update = update_login.Text.Trim();
            string mail_update = update_email.Text.Trim().ToLower();
            string pass1_update = update_pass1.Password.Trim();
            string pass2_update = update_pass2.Password.Trim();

            mail_update = (mail_update == "") ? mail_update = null : mail_update = mail_update;
            pass1_update = (pass1_update == "") ? pass1_update = null : pass1_update = pass1_update;
            pass2_update = (pass2_update == "") ? pass2_update = null : pass2_update = pass2_update;

            if (mail_update != null || pass1_update != null || pass2_update != null)
            {
                update_email.Text = null;
                
                var md5 = MD5.Create();
                string pass_md5 = "300$";
                try
                {
                    md5 = MD5.Create();
                    pass_md5 = Convert.ToBase64String(md5.ComputeHash(Encoding.UTF8.GetBytes(pass1_update)));
                }
                catch
                {
                    MessageBox.Show("Ошибка с MD5");
                }
                user login_check;
                using (ApplicationContext db = new ApplicationContext())
                {
                    login_check = db.users.Where(b => b.Login == profile_user_login).FirstOrDefault();
                }
                user updating = null;





                if (pass1_update != pass2_update)
                {
                    update_pass1.ToolTip = "Пароли не совпадают";
                    update_pass1.BorderBrush = Brushes.Crimson;
                    update_pass2.ToolTip = "Пароли не совпадают";
                    update_pass2.BorderBrush = Brushes.Crimson;

                }
                else if (pass2_update.Length < 4 && pass1_update.Length < 4)
                {

                    update_pass1.ToolTip = "Длина пароля должна быть больше 4 символов";
                    update_pass2.ToolTip = "Длина пароля должна быть больше 4 символов";
                    update_pass1.BorderBrush = Brushes.Crimson;
                    update_pass2.BorderBrush = Brushes.Crimson;
                } else if (pass1_update != null && pass2_update != null)
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        updating = db.users.Where(b => b.Login == profile_user_login).FirstOrDefault();
                        updating.Password = pass_md5;
                        db.SaveChanges();

                    }

                    MessageBox.Show("Пароль изменен");
                    MessageBox.Show(update_pass1.ToString());
                    update_pass1.ToolTip = null;
                    update_pass1.BorderBrush = Brushes.Black;
                    update_pass2.BorderBrush = Brushes.Black;
                    update_pass2.ToolTip = null;
                    update_pass1.Password = null;
                    update_pass2.Password = null;
                }


                if (mail_update.Length < 5)
                {
                    update_email.ToolTip = "Длина почты должна быть больше 5 символов";
                    update_email.BorderBrush = Brushes.Crimson;
                }
                else
                {
                    update_email.ToolTip = null;
                    update_email.BorderBrush = Brushes.Black;
                }


                if (!mail_update.Contains('@') || !mail_update.Contains('.'))
                {
                    update_email.ToolTip = "Почта введена неправильно";
                    update_email.BorderBrush = Brushes.Crimson;
                }
                else if (mail_update.Length < 5)
                {
                    update_email.ToolTip = "Длина почты должна быть больше 5 символов";
                }
                else
                {
                    if (updating != null)
                    {
                        updating.Email = mail_update;
                    }
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        updating = db.users.Where(b => b.Login == profile_user_login).FirstOrDefault();
                        updating.Email = mail_update;
                        db.SaveChanges();
                    }
                    
                    MessageBox.Show("Почта изменена");
                    update_email.ToolTip = null;
                    update_email.BorderBrush = Brushes.Black;

                }


                
                } else
                {
                MessageBox.Show("Ничего не изменилось 🤨");
                }
        }

        private void plaster_check_Checked(object sender, RoutedEventArgs e)
        {
            check_plaster = true;
            plaster_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }

        private void plaster_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_plaster = false;
            plaster_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        private void grunt_check_Checked(object sender, RoutedEventArgs e)
        {
            check_grunt = true;
            grunt_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }

        private void grunt_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_grunt = false;
            grunt_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        private void ground_coat_check_Checked(object sender, RoutedEventArgs e)
        {
            check_ground_coat = true;
            ground_coat_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }

        private void ground_coat_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_ground_coat = false;
            ground_coat_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        private void paint_check_Checked(object sender, RoutedEventArgs e)
        {
            check_paint = true;
            paint_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }

        private void paint_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_paint = false;
            paint_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        int type_calc_check = 0;
        //when type of calc changed
        private void Paint_calcs_combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            selected_type_of_calc = Convert.ToByte(paint_calcs_combobox.SelectedIndex + 1);
            //MessageBox.Show(selected_type_of_calc.ToString());
            //Thickness space_margin = space_grid.Margin;
            textblock_paint_result.Text = "Нажмите \"Рассчитать\"";
            switch (selected_type_of_calc)
            {
                case 1:
                    //space_grid.Margin = new Thickness(0, 300, 0, 0);
                    //textblock_paint_result.Margin = new Thickness(0, 115, 0, 0);
                    spaces_top = 100;
                    height2_grid.Visibility = Visibility.Hidden;
                    height3_grid.Visibility = Visibility.Hidden;
                    height4_grid.Visibility = Visibility.Hidden;
                    type_calc_check = 1;
                    if (first_here)
                    {
                        do_calculation.IsEnabled = true;
                    } else if (rooms) {
                        do_calculation.IsEnabled = false;
                    }
                    if (user_type != 3 && first_here || rooms) add_room_button.IsEnabled = true; 
                    else
                        add_room_button.IsEnabled = false;
                    first_here = false;
                    break;
                case 2:
                    type_calc_check = 2;
                    //space_grid.Margin = new Thickness(0, 345, 0, 0);
                    //textblock_paint_result.Margin = new Thickness(0, 160, 0, 0);
                    height2_grid.Visibility = Visibility.Visible;
                    height3_grid.Visibility = Visibility.Hidden;
                    height4_grid.Visibility = Visibility.Hidden;
                    spaces_top = 170;

                    if (first_here)
                    {
                        do_calculation.IsEnabled = true;
                    }
                    else if (rooms)
                    {
                        do_calculation.IsEnabled = false;
                    }
                    if (user_type != 3 && first_here || rooms) add_room_button.IsEnabled = true;
                    else
                        add_room_button.IsEnabled = false;
                    first_here = false;
                    break;
                case 3:
                    type_calc_check = 3;
                    height2_grid.Visibility = Visibility.Visible;
                    height3_grid.Visibility = Visibility.Visible;
                    height4_grid.Visibility = Visibility.Visible;
                    spaces_top = 170;
                    if (first_here)
                    {
                        do_calculation.IsEnabled = true;
                    }
                    else if (rooms)
                    {
                        do_calculation.IsEnabled = false;
                    }
                    if (user_type != 3 && first_here || rooms) add_room_button.IsEnabled = true;
                    else
                        add_room_button.IsEnabled = false;
                    first_here = false;
                    break;
                /*case 4:
                    type_calc_check = 4;
                    if (first_here)
                    {
                        do_calculation.IsEnabled = true;
                    }
                    else if (rooms)
                    {
                        do_calculation.IsEnabled = false;
                    }
                    if (user_type != 3 && first_here || rooms) add_room_button.IsEnabled = true;
                    else
                        add_room_button.IsEnabled = false;
                    first_here = false;
                    break;*/
            }
            space_grid.Margin = new Thickness(0, spaces_top, 190, 4);
        }
        // add space button
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            space_width = check_value(space_width_textbox.Text);
            space_height = check_value(space_height_textbox.Text);
            if (space_height > 0 && space_width > 0)
            {
                space_id++;
                space_square = space_width * space_height;
                space_listbox.Items.Add("Проем №" + space_id + ", Ширина - " + space_width + ", Высота - " + space_height + ", Площадь - " + space_square + " - " + measure_ln + "\u00B2");
                all_space_square += space_square;
            } else
            {
                warning_number_window();
            }
        }


        private void Space_history_listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Account_info_btn_Click(object sender, RoutedEventArgs e)
        {
            hide_profile(0);
            hide_menu2(1);
            update_login.Text = profile_user_login;
            update_email.Text = profile_user_mail;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void history_button_Click(object sender, RoutedEventArgs e)
        {
            admin_grid.Visibility = Visibility.Visible;
            hide_menu2(1);
            users_list_update();
        }

        private void delete_user_button_Click(object sender, RoutedEventArgs e)
        {
            var a = Int32.TryParse(deleted_user_id_textbox.Text.ToString(), out int value_1);
            if (a)
            {
                int delete_id = Math.Abs(Int32.Parse(deleted_user_id_textbox.Text.ToString()));
                user admin_stat = null;
                using (ApplicationContext db = new ApplicationContext())
                {
                    admin_stat = db.users.Where(b => b.id == delete_id).FirstOrDefault();
                }
                try
                {
                    if (admin_stat != null)
                    {

                        if (admin_stat.Admin_status != "true")
                        {
                            try
                            {
                                var input_del = db.users.FirstOrDefault(x => x.id == delete_id);
                                db.users.Remove(input_del);
                                db.SaveChanges();
                                users_list_update();
                            }
                            catch
                            {

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка");
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
            else
            {
                warning_number_window();
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            void Create(string filePath)
            {
                string calc_id, user_id, calc_type, an1, an2, an3, an4, w1, w2, l1, l2, h1, h2, h3, h4, space_square, date;
                string wall_square, ceiling_perimetr, ceiling_area, ground_area, ground_perimetr, height_length;
                List<input_paints> inputs;
                List<output_paints> outputs;
                List<materials> materials;
                if (user_type == 2)
                {
                    inputs = db.input_paint.ToList();
                    outputs = db.output_paint.ToList();
                    materials = db.material.ToList();
                }
                else
                {
                    inputs = db.input_paint.Where(b => b.User_id == current_user_id.ToString()).ToList();
                    outputs = db.output_paint.Where(b => b.User_id == current_user_id.ToString()).ToList();
                    materials = db.material.Where(b => b.User_id == current_user_id.ToString()).ToList();
                }

                string a_col = "A", b_col = "B", c_col = "C", d_col = "D", e_col = "E", f_col = "F", g_col = "G", h_col = "H";
                string i_col = "I", j_col = "J", k_col = "K", l_col = "L", m_col = "M", n_col = "N", o_col = "O", p_col = "P";
                string q_col = "Q", r_col = "R", s_col = "S", t_col = "T", u_col = "U", v_col = "V", w_col = "W", x_col = "X";
                int row_count = 2;

                var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add("Расчёты");

                var colu_a1 = ws.Column("A");
                var colu_b1 = ws.Column("B");
                var colu_c1 = ws.Column("C");
                var colu_d1 = ws.Column("D");
                var colu_e1 = ws.Column("E");
                var colu_f1 = ws.Column("F");
                var colu_g1 = ws.Column("G");
                var colu_h1 = ws.Column("H");
                var colu_i1 = ws.Column("I");
                var colu_j1 = ws.Column("J");
                var colu_k1 = ws.Column("K");
                var colu_l1 = ws.Column("L");
                var colu_m1 = ws.Column("M");
                var colu_n1 = ws.Column("N");
                var colu_o1 = ws.Column("O");
                var colu_p1 = ws.Column("P");
                var colu_q1 = ws.Column("Q");
                var colu_r1 = ws.Column("R");
                var colu_s1 = ws.Column("S");
                var colu_t1 = ws.Column("T");
                var colu_u1 = ws.Column("U");
                var colu_v1 = ws.Column("V");
                var colu_w1 = ws.Column("W");
                var colu_x1 = ws.Column("X");



                colu_a1.Width = 9; colu_b1.Width = 15; colu_c1.Width = 11; colu_d1.Width = 9; colu_e1.Width = 9; colu_f1.Width = 9;
                colu_g1.Width = 9; colu_h1.Width = 11; colu_i1.Width = 11; colu_j1.Width = 11; colu_k1.Width = 11; colu_l1.Width = 11;
                colu_m1.Width = 11; colu_n1.Width = 11; colu_o1.Width = 11; colu_p1.Width = 11; colu_q1.Width = 17;
                colu_r1.Width = 17; colu_s1.Width = 13; colu_t1.Width = 14; colu_u1.Width = 17; colu_v1.Width = 24; colu_w1.Width = 20; colu_x1.Width = 20;

                var rngTable1 = ws.Range("A1:X1");
                var rngHeaders1 = rngTable1.Range("A1:X1");
                rngHeaders1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders1.Style.Font.Bold = true;
                rngHeaders1.Style.Fill.BackgroundColor = XLColor.Aqua;

                var rngtable1 = ws.Range("A2:X200");
                var rngnumbers1 = rngtable1.Range("A2:X200");
                rngnumbers1.DataType = XLDataType.Number;
                rngnumbers1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                ws.Cell("A1").Value = "Id Расчета";
                ws.Cell("B1").Value = "Id Пользователя";
                ws.Cell("C1").Value = "Тип расчёта";
                ws.Cell("D1").Value = "Угол №1";
                ws.Cell("E1").Value = "Угол №2";
                ws.Cell("F1").Value = "Угол №3";
                ws.Cell("G1").Value = "Угол №4";
                ws.Cell("H1").Value = "Ширнина №1";
                ws.Cell("I1").Value = "Ширнина №2";
                ws.Cell("J1").Value = "Длина №1";
                ws.Cell("K1").Value = "Длина №2";
                ws.Cell("L1").Value = "Высота №1";
                ws.Cell("M1").Value = "Высота №2";
                ws.Cell("N1").Value = "Высота №3";
                ws.Cell("O1").Value = "Высота №4";
                ws.Cell("P1").Value = "Площадь стен";
                ws.Cell("Q1").Value = "Периметр потолка";
                ws.Cell("R1").Value = "Площадь потолка";
                ws.Cell("S1").Value = "Площадь пола";
                ws.Cell("T1").Value = "Периметр пола";
                ws.Cell("U1").Value = "Площадь проемов";
                ws.Cell("V1").Value = "Общая высота всех углов";
                ws.Cell("W1").Value = "Дата";
                ws.Cell("X1").Value = "Номер комнаты";


                foreach (input_paints input in inputs)
                {
                    int cur_id = input.id;
                    calc_id = cur_id.ToString();
                    user_id = current_user_id.ToString();
                    calc_type = input.Calc_type;
                    an1 = input.An1;
                    an2 = input.An2;
                    an3 = input.An3;
                    an4 = input.An4;
                    w1 = input.W1;
                    w2 = input.W2;
                    l1 = input.L1;
                    l2 = input.L2;
                    h1 = input.H1;
                    h2 = input.H2;
                    h3 = input.H3;
                    h4 = input.H4;
                    string h5 = input.Room_number;
                    space_square = input.Space_square;
                    date = input.Date;
                    int out_id;
                    string out_square = "0", out_square2 = "0";
                    foreach (output_paints output in outputs)
                    {

                        if (output.id == cur_id)
                        {
                            wall_square = output.Wall_square;
                            ceiling_perimetr = output.Ceiling_perimetr;
                            ceiling_area = output.Ceiling_area;
                            ground_area = output.Ground_area;
                            ground_perimetr = output.Ground_perimetr;
                            height_length = output.Height_lenght;

                            a_col += row_count.ToString();
                            b_col += row_count.ToString();
                            c_col += row_count.ToString();
                            d_col += row_count.ToString();
                            e_col += row_count.ToString();
                            f_col += row_count.ToString();
                            g_col += row_count.ToString();
                            h_col += row_count.ToString();
                            i_col += row_count.ToString();
                            j_col += row_count.ToString();
                            k_col += row_count.ToString();
                            l_col += row_count.ToString();
                            m_col += row_count.ToString();
                            n_col += row_count.ToString();
                            o_col += row_count.ToString();
                            p_col += row_count.ToString();
                            q_col += row_count.ToString();
                            r_col += row_count.ToString();
                            s_col += row_count.ToString();
                            t_col += row_count.ToString();
                            u_col += row_count.ToString();
                            v_col += row_count.ToString();
                            w_col += row_count.ToString();
                            x_col += row_count.ToString();

                            ws.Cell(a_col).Value = cur_id;
                            ws.Cell(b_col).Value = current_user_id;
                            ws.Cell(c_col).Value = calc_type;
                            ws.Cell(d_col).Value = an1;
                            ws.Cell(e_col).Value = an2;
                            ws.Cell(f_col).Value = an3;
                            ws.Cell(g_col).Value = an4;
                            ws.Cell(h_col).Value = w1;
                            ws.Cell(i_col).Value = w2;
                            ws.Cell(j_col).Value = l1;
                            ws.Cell(k_col).Value = l2;
                            ws.Cell(l_col).Value = h1;
                            ws.Cell(m_col).Value = h2;
                            ws.Cell(n_col).Value = h3;
                            ws.Cell(o_col).Value = h4;
                            ws.Cell(p_col).Value = wall_square;
                            ws.Cell(q_col).Value = ceiling_perimetr;
                            ws.Cell(r_col).Value = ceiling_area;
                            ws.Cell(s_col).Value = ground_area;
                            ws.Cell(t_col).Value = ground_perimetr;
                            ws.Cell(u_col).Value = space_square;
                            ws.Cell(v_col).Value = height_length;
                            ws.Cell(w_col).Value = date;
                            ws.Cell(x_col).Value = h5;
                            a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                            i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                            q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                            row_count++;
                        }
                    }

                    
                }
                a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                row_count = 2;
                var ws2 = wb.Worksheets.Add("Обои, Штукатурка");
                ws2.Cell("A1").Value = "Id Расчета";
                ws2.Cell("B1").Value = "Id Пользователя";
                ws2.Cell("C1").Value = "Ширина обоев";
                ws2.Cell("D1").Value = "Ширина рулона";
                ws2.Cell("E1").Value = "Длина обоев";
                ws2.Cell("F1").Value = "Кол-во рулонов";
                ws2.Cell("G1").Value = "Кол-во слоев штукатурки";
                ws2.Cell("H1").Value = "Вес емкости штукатурки";
                ws2.Cell("I1").Value = "Расход емкости";
                ws2.Cell("J1").Value = "Площадь расхода";
                ws2.Cell("K1").Value = "Вес емкостей";
                ws2.Cell("L1").Value = "Кол-во емкостей";
                //ws2.Cell("M1").Value = "Дата";
                var colu_a = ws2.Column("A");
                var colu_b = ws2.Column("B");
                var colu_c = ws2.Column("C");
                var colu_d = ws2.Column("D");
                var colu_e = ws2.Column("E");
                var colu_f = ws2.Column("F");
                var colu_g = ws2.Column("G");
                var colu_h = ws2.Column("H");
                var colu_i = ws2.Column("I");
                var colu_j = ws2.Column("J");
                var colu_k = ws2.Column("K");
                var colu_l = ws2.Column("L");

                var rngTable2 = ws2.Range("A1:L1");
                var rngHeaders2 = rngTable2.Range("A1:L1");
                rngHeaders2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders2.Style.Font.Bold = true;
                rngHeaders2.Style.Fill.BackgroundColor = XLColor.Aqua;

                var rngtable2 = ws2.Range("A2:W200");
                var rngnumbers2 = rngtable2.Range("A2:W200");
                rngnumbers2.DataType = XLDataType.Number;
                rngnumbers2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                colu_a.Width = 9; colu_b.Width = 14; colu_c.Width = 13; colu_d.Width = 13.5; colu_e.Width = 11; colu_f.Width = 13.5;
                colu_g.Width = 21.5; colu_h.Width = 20; colu_i.Width = 13.5; colu_j.Width = 15.3; colu_k.Width = 12; colu_l.Width = 15;


                foreach (materials material in materials)
                {
                    int cur_id2 = material.id;
                    calc_id = cur_id2.ToString();
                    user_id = current_user_id.ToString();
                    calc_type = material.In_wallpapers_width;
                    an1 = material.In_wallpapers_circle_length;
                    an2 = material.Wallpapers_length_m;
                    an3 = material.Wallpapers_amount;
                    an4 = material.In_plaster_thick;
                    w1 = material.In_plaster_kg_mesh;
                    w2 = material.In_plaster_m_mesh;
                    l1 = material.Plaster_volume_m;
                    l2 = material.Plaster_kg;
                    h1 = material.Plaster_amount;
                    //date = material.Date;
                    int out_id2;
                    //string out_square = "0", out_square2 = "0";


                    if (material.id == cur_id2)
                    {
                        /*wall_square = output.Wall_square;
                        ceiling_perimetr = output.Ceiling_perimetr;
                        ceiling_area = output.Ceiling_area;
                        ground_area = output.Ground_area;
                        ground_perimetr = output.Ground_perimetr;
                        height_length = output.Height_lenght;*/

                        a_col += row_count.ToString();
                        b_col += row_count.ToString();
                        c_col += row_count.ToString();
                        d_col += row_count.ToString();
                        e_col += row_count.ToString();
                        f_col += row_count.ToString();
                        g_col += row_count.ToString();
                        h_col += row_count.ToString();
                        i_col += row_count.ToString();
                        j_col += row_count.ToString();
                        k_col += row_count.ToString();
                        l_col += row_count.ToString();
                        //m_col += row_count.ToString();


                        ws2.Cell(a_col).Value = cur_id2;
                        ws2.Cell(b_col).Value = current_user_id;
                        ws2.Cell(c_col).Value = calc_type;
                        ws2.Cell(d_col).Value = an1;
                        ws2.Cell(e_col).Value = an2;
                        ws2.Cell(f_col).Value = an3;
                        ws2.Cell(g_col).Value = an4;
                        ws2.Cell(h_col).Value = w1;
                        ws2.Cell(i_col).Value = w2;
                        ws2.Cell(j_col).Value = l1;
                        ws2.Cell(k_col).Value = l2;
                        ws2.Cell(l_col).Value = h1;
                        //ws2.Cell(m_col).Value = date;h1;
                        


                        a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                        i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                        q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                        row_count++;
                    }
                }






                a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                row_count = 2;
                var ws3 = wb.Worksheets.Add("Грунтовка, Шпаклевка");
                ws3.Cell("A1").Value = "Id Расчета";
                ws3.Cell("B1").Value = "Id Пользователя";
                ws3.Cell("C1").Value = "кол-во слоев грунтовки";
                ws3.Cell("D1").Value = "вес емкости";
                ws3.Cell("E1").Value = "расход емкости";
                ws3.Cell("F1").Value = "площадь покрытия";
                ws3.Cell("G1").Value = "вес емкостей";
                ws3.Cell("H1").Value = "кол-во емкостей";
                ws3.Cell("I1").Value = "кол-во слоев шпаклевки";
                ws3.Cell("J1").Value = "вес емкости";
                ws3.Cell("K1").Value = "расход емкости";
                ws3.Cell("L1").Value = "площадь покрытия";
                ws3.Cell("M1").Value = "вес емкостей";
                ws3.Cell("N1").Value = "кол-во емкостей";
                //ws2.Cell("M1").Value = "Дата";
                var colu_a3 = ws3.Column("A");
                var colu_b3 = ws3.Column("B");
                var colu_c3 = ws3.Column("C");
                var colu_d3 = ws3.Column("D");
                var colu_e3 = ws3.Column("E");
                var colu_f3 = ws3.Column("F");
                var colu_g3 = ws3.Column("G");
                var colu_h3 = ws3.Column("H");
                var colu_i3 = ws3.Column("I");
                var colu_j3 = ws3.Column("J");
                var colu_k3 = ws3.Column("K");
                var colu_l3 = ws3.Column("L");
                var colu_m3 = ws3.Column("M");
                var colu_n3 = ws3.Column("N");

                var rngTable3 = ws3.Range("A1:N1");
                var rngHeaders3 = rngTable3.Range("A1:N1");
                rngHeaders3.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders3.Style.Font.Bold = true;
                rngHeaders3.Style.Fill.BackgroundColor = XLColor.Aqua;

                var rngtable3 = ws3.Range("A2:W200");
                var rngnumbers3 = rngtable3.Range("A2:W200");
                rngnumbers3.DataType = XLDataType.Number;
                rngnumbers3.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                colu_a3.Width = 9; colu_b3.Width = 14; colu_c3.Width = 20; colu_d3.Width = 11.5; colu_e3.Width = 14; colu_f3.Width = 16.5;
                colu_g3.Width = 12; colu_h3.Width = 15; colu_i3.Width = 22; colu_j3.Width = 11.5; colu_k3.Width = 14; colu_l3.Width = 17;
                colu_m3.Width = 12; colu_n3.Width = 15;


                foreach (materials material in materials)
                {
                    int cur_id2 = material.id;
                    calc_id = cur_id2.ToString();
                    user_id = current_user_id.ToString();
                    calc_type = material.In_grunt_layers;
                    an1 = material.In_grunt_kg_mesh;
                    an2 = material.In_grunt_m_mesh;
                    an3 = material.Grunt_volume_m;
                    an4 = material.Grunt_kg;
                    w1 = material.Grunt_amount;
                    w2 = material.In_ground_coat_thick;
                    l1 = material.In_ground_coat_kg_mesh;
                    l2 = material.In_ground_coat_m_mesh;
                    h1 = material.Ground_coat_volume_m;
                    h2 = material.Ground_coat_volume_kg;
                    h3 = material.Ground_coat_amount;

                    //date = material.Date;
                    int out_id2;
                    //string out_square = "0", out_square2 = "0";


                    if (material.id == cur_id2)
                    {
                        /*wall_square = output.Wall_square;
                        ceiling_perimetr = output.Ceiling_perimetr;
                        ceiling_area = output.Ceiling_area;
                        ground_area = output.Ground_area;
                        ground_perimetr = output.Ground_perimetr;
                        height_length = output.Height_lenght;*/

                        a_col += row_count.ToString();
                        b_col += row_count.ToString();
                        c_col += row_count.ToString();
                        d_col += row_count.ToString();
                        e_col += row_count.ToString();
                        f_col += row_count.ToString();
                        g_col += row_count.ToString();
                        h_col += row_count.ToString();
                        i_col += row_count.ToString();
                        j_col += row_count.ToString();
                        k_col += row_count.ToString();
                        l_col += row_count.ToString();
                        m_col += row_count.ToString();
                        n_col += row_count.ToString();

                        ws3.Cell(a_col).Value = cur_id2;
                        ws3.Cell(b_col).Value = current_user_id;
                        ws3.Cell(c_col).Value = calc_type;
                        ws3.Cell(d_col).Value = an1;
                        ws3.Cell(e_col).Value = an2;
                        ws3.Cell(f_col).Value = an3;
                        ws3.Cell(g_col).Value = an4;
                        ws3.Cell(h_col).Value = w1;
                        ws3.Cell(i_col).Value = w2;
                        ws3.Cell(j_col).Value = l1;
                        ws3.Cell(k_col).Value = l2;
                        ws3.Cell(l_col).Value = h1;
                        ws3.Cell(m_col).Value = h2;
                        ws3.Cell(n_col).Value = h3;
                        


                        a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                        i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                        q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                        row_count++;
                    }
                }






                a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                row_count = 2;
                var ws4 = wb.Worksheets.Add("Краска");
                ws4.Cell("A1").Value = "Id Расчета";
                ws4.Cell("B1").Value = "Id Пользователя";
                ws4.Cell("C1").Value = "кол-во слоев краски";
                ws4.Cell("D1").Value = "вес емкости";
                ws4.Cell("E1").Value = "расход емкости";
                ws4.Cell("F1").Value = "площадь покрытия";
                ws4.Cell("G1").Value = "вес емкостей";
                ws4.Cell("H1").Value = "кол-во емкостей";
                
                //ws2.Cell("M1").Value = "Дата";
                var colu_a4 = ws4.Column("A");
                var colu_b4 = ws4.Column("B");
                var colu_c4 = ws4.Column("C");
                var colu_d4 = ws4.Column("D");
                var colu_e4 = ws4.Column("E");
                var colu_f4 = ws4.Column("F");
                var colu_g4 = ws4.Column("G");
                var colu_h4 = ws4.Column("H");

                var rngtable4 = ws4.Range("A2:W200");
                var rngnumbers4 = rngtable4.Range("A2:W200");
                rngnumbers4.DataType = XLDataType.Number;
                rngnumbers4.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                var rngTable4 = ws4.Range("A1:H1");
                var rngHeaders4 = rngTable4.Range("A1:H1");
                rngHeaders4.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders4.Style.Font.Bold = true;
                rngHeaders4.Style.Fill.BackgroundColor = XLColor.Aqua;


                colu_a4.Width = 9; colu_b4.Width = 14; colu_c4.Width = 20; colu_d4.Width = 11.5; colu_e4.Width = 14; colu_f4.Width = 16.5;
                colu_g4.Width = 12; colu_h4.Width = 15; 


                foreach (materials material in materials)
                {
                    int cur_id2 = material.id;
                    calc_id = cur_id2.ToString();
                    user_id = current_user_id.ToString();
                    calc_type = material.In_paint_layers;
                    an1 = material.In_paint_kg_mesh;
                    an2 = material.In_paint_m_mesh;
                    an3 = material.Paint_volume_m;
                    an4 = material.Paint_kg;
                    w1 = material.Paint_amount;
                   
                    //date = material.Date;
                    int out_id2;
                    //string out_square = "0", out_square2 = "0";


                    if (material.id == cur_id2)
                    {
                        /*wall_square = output.Wall_square;
                        ceiling_perimetr = output.Ceiling_perimetr;
                        ceiling_area = output.Ceiling_area;
                        ground_area = output.Ground_area;
                        ground_perimetr = output.Ground_perimetr;
                        height_length = output.Height_lenght;*/

                        a_col += row_count.ToString();
                        b_col += row_count.ToString();
                        c_col += row_count.ToString();
                        d_col += row_count.ToString();
                        e_col += row_count.ToString();
                        f_col += row_count.ToString();
                        g_col += row_count.ToString();
                        h_col += row_count.ToString();
                        

                        ws4.Cell(a_col).Value = cur_id2;
                        ws4.Cell(b_col).Value = current_user_id;
                        ws4.Cell(c_col).Value = calc_type;
                        ws4.Cell(d_col).Value = an1;
                        ws4.Cell(e_col).Value = an2;
                        ws4.Cell(f_col).Value = an3;
                        ws4.Cell(g_col).Value = an4;
                        ws4.Cell(h_col).Value = w1;
                     



                        a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                        i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                        q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                        row_count++;
                    }
                }
                wb.SaveAs(filePath);
                // Creating a new workbook
                /*var wb = new XLWorkbook();

                //Adding a worksheet
                var ws = wb.Worksheets.Add("Contacts");

                //Adding text
                //Title
                ws.Cell("B2").Value = "Contacts";
                //First Names
                ws.Cell("B3").Value = "FName";
                ws.Cell("B4").Value = "John";
                ws.Cell("B5").Value = "Hank";
                ws.Cell("B6").Value = "Dagny";
                //Last Names
                ws.Cell("C3").Value = "LName";
                ws.Cell("C4").Value = "Galt";
                ws.Cell("C5").Value = "Rearden";
                ws.Cell("C6").Value = "Taggart";

                //Adding more data types
                //Is an outcast?
                ws.Cell("D3").Value = "Outcast";
                ws.Cell("D4").Value = true;
                ws.Cell("D5").Value = false;
                ws.Cell("D6").Value = false;
                //Date of Birth
                ws.Cell("E3").Value = "DOB";
                ws.Cell("E4").Value = new DateTime(1919, 1, 21);
                ws.Cell("E5").Value = new DateTime(1907, 3, 4);
                ws.Cell("E6").Value = new DateTime(1921, 12, 15);
                //Income
                ws.Cell("F3").Value = "Income";
                ws.Cell("F4").Value = 2000;
                ws.Cell("F5").Value = 40000;
                ws.Cell("F6").Value = 10000;

                //Defining ranges
                //From worksheet
                var rngTable = ws.Range("B2:F6");
                //From another range
                var rngDates = rngTable.Range("E4:E6");
                var rngNumbers = rngTable.Range("F4:F6");

                //Formatting dates and numbers
                //Using a OpenXML's predefined formats
                rngDates.Style.NumberFormat.NumberFormatId = 15;
                //Using a custom format
                rngNumbers.Style.NumberFormat.Format = "$ #,##0";

                //Formatting headers
                var rngHeaders = rngTable.Range("B3:F3");
                rngHeaders.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders.Style.Font.Bold = true;
                rngHeaders.Style.Fill.BackgroundColor = XLColor.Aqua;

                //Adding grid lines
                rngTable.Style.Border.BottomBorder = XLBorderStyleValues.Thin;

                //Format title cell
                rngTable.Cell(1, 1).Style.Font.Bold = true;
                rngTable.Cell(1, 1).Style.Fill.BackgroundColor = XLColor.CornflowerBlue;
                rngTable.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                //Merge title cells
                rngTable.Row(1).Merge(); // We could've also used: rngTable.Range("A1:E1").Merge()

                //Add thick borders
                rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thick;

                // You can also specify the border for each side with:
                // rngTable.FirstColumn().Style.Border.LeftBorder = XLBorderStyleValues.Thick;
                // rngTable.LastColumn().Style.Border.RightBorder = XLBorderStyleValues.Thick;
                // rngTable.FirstRow().Style.Border.TopBorder = XLBorderStyleValues.Thick;
                // rngTable.LastRow().Style.Border.BottomBorder = XLBorderStyleValues.Thick;

                // Adjust column widths to their content
                ws.Columns(2, 6).AdjustToContents();

                //Saving the workbook
                */
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Таблица Excel |*.xlsx";
            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    string path2 = saveFileDialog.FileName;
                    Create(path2);

                } catch
                {
                    MessageBox.Show("Ошибка создания файла XSLS");
                }
                MessageBox.Show("Готово");
            }    
        }
        Boolean rooms = false;
        Boolean first_room = true;
        private void add_room_button_Click(object sender, RoutedEventArgs e)
        {
            rooms = true;
            if (first_room)
            {
                first_room = false;
            }
            else
            {
                room_number_export++;
            }
            calculation();
            do_calculation.IsEnabled = false;
        }

        private void finish_button_Click(object sender, RoutedEventArgs e)
        {
            rooms = false;
            room_number_export = 1;
            if (user_type != 3)
            {
                do_calculation.IsEnabled = true;
            }
        }

        // clear all textboxes button
        private void Clear_button_Click(object sender, RoutedEventArgs e)
        {
            space_id = 0;
            space_square = 0;
            all_space_square = 0;
            space_listbox.Items.Clear();
            textblock_paint_result.Text = "";
            width_textbox.Text = "";
            height_textbox.Text = "";
            length_textbox.Text = "";
            height2_textbox.Text = "";
            space_height_textbox.Text = "";
            space_width_textbox.Text = "";
=======


        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            grid_menu.Visibility = Visibility.Visible;
            main_menu_grid.Visibility = Visibility.Hidden;
            history_button.IsEnabled = false;
            history_btn.IsEnabled = false;
            add_room_button.IsEnabled = false;
            account_info_btn.IsEnabled = false;
            user_type = 3;
>>>>>>> Stashed changes

            login_textbox.Text = "";
            pass_textbox.Password = "";
            textblock_paint_result.Text = "Выберете \"Тип расчёта\"";
        }
<<<<<<< Updated upstream
        // checkbox spaces in true position
        Boolean space_check_value;
        private void Spaces_check_Checked(object sender, RoutedEventArgs e)
        {
            space_grid.Visibility = Visibility.Visible;
            space_check_value = true;
        }
>>>>>>> Stashed changes
=======

        
        private void wallpaper_check_Checked(object sender, RoutedEventArgs e)
        {
            check_wall = true;
            wallpapers_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }
        private void wallpaper_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_wall = false;
            wallpapers_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        // 0:31 am fuck
        int grid_number = 2;
        int grids = 0;
        Boolean grid_first = true;
        public void adaptive_epta()
        {
            if (!grid_first)
            {
                //grids += 1;
                while (grids > 0)
                {
                    grid_griddiest.RowDefinitions.RemoveAt(grids);
                    //grid_griddiest.RowDefinitions.Remove(new RowDefinition());
                    grids--;
                }
                
            } else
            {
                grid_first = false;
            }
            if (check_wall)
            {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto } );
                wallpapers_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            }
            if (check_plaster)
            {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                plaster_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            } if (check_grunt)
            {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                grunt_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            } if (check_ground_coat) {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                ground_coat_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            } if (check_paint)
            {
                grid_griddiest.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                paint_grid.SetValue(Grid.RowProperty, grid_number);
                grid_number++;
                grids++;
            }
            grid_number = 2;

        }

        Boolean first_here = true;
        Boolean check_wall = false;
        Boolean check_plaster = false;
        Boolean check_grunt = false;
        Boolean check_ground_coat = false;
        Boolean check_paint = false;

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
           new _3d_model(width1, length1, height1, height1, height1).ShowDialog();
        }

        //profile updater
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
          /*  login_info_textbox.Text = null;
            mail_info_textbox.Text = null;
            pass_info_textbox.Text = null;
            pass2_info_textbox.Text = null;*/

            string login_update = update_login.Text.Trim();
            string mail_update = update_email.Text.Trim().ToLower();
            string pass1_update = update_pass1.Password.Trim();
            string pass2_update = update_pass2.Password.Trim();

            mail_update = (mail_update == "") ? mail_update = null : mail_update = mail_update;
            pass1_update = (pass1_update == "") ? pass1_update = null : pass1_update = pass1_update;
            pass2_update = (pass2_update == "") ? pass2_update = null : pass2_update = pass2_update;

            if (mail_update != null || pass1_update != null || pass2_update != null)
            {
                update_email.Text = null;
                
                var md5 = MD5.Create();
                string pass_md5 = "300$";
                try
                {
                    md5 = MD5.Create();
                    pass_md5 = Convert.ToBase64String(md5.ComputeHash(Encoding.UTF8.GetBytes(pass1_update)));
                }
                catch
                {
                    MessageBox.Show("Ошибка с MD5");
                }
                user login_check;
                using (ApplicationContext db = new ApplicationContext())
                {
                    login_check = db.users.Where(b => b.Login == profile_user_login).FirstOrDefault();
                }
                user updating = null;





                if (pass1_update != pass2_update)
                {
                    update_pass1.ToolTip = "Пароли не совпадают";
                    update_pass1.BorderBrush = Brushes.Crimson;
                    update_pass2.ToolTip = "Пароли не совпадают";
                    update_pass2.BorderBrush = Brushes.Crimson;

                }
                else if (pass2_update.Length < 4 && pass1_update.Length < 4)
                {

                    update_pass1.ToolTip = "Длина пароля должна быть больше 4 символов";
                    update_pass2.ToolTip = "Длина пароля должна быть больше 4 символов";
                    update_pass1.BorderBrush = Brushes.Crimson;
                    update_pass2.BorderBrush = Brushes.Crimson;
                } else if (pass1_update != null && pass2_update != null)
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        updating = db.users.Where(b => b.Login == profile_user_login).FirstOrDefault();
                        updating.Password = pass_md5;
                        db.SaveChanges();

                    }

                    MessageBox.Show("Пароль изменен");
                    MessageBox.Show(update_pass1.ToString());
                    update_pass1.ToolTip = null;
                    update_pass1.BorderBrush = Brushes.Black;
                    update_pass2.BorderBrush = Brushes.Black;
                    update_pass2.ToolTip = null;
                    update_pass1.Password = null;
                    update_pass2.Password = null;
                }


                if (mail_update.Length < 5)
                {
                    update_email.ToolTip = "Длина почты должна быть больше 5 символов";
                    update_email.BorderBrush = Brushes.Crimson;
                }
                else
                {
                    update_email.ToolTip = null;
                    update_email.BorderBrush = Brushes.Black;
                }


                if (!mail_update.Contains('@') || !mail_update.Contains('.'))
                {
                    update_email.ToolTip = "Почта введена неправильно";
                    update_email.BorderBrush = Brushes.Crimson;
                }
                else if (mail_update.Length < 5)
                {
                    update_email.ToolTip = "Длина почты должна быть больше 5 символов";
                }
                else
                {
                    if (updating != null)
                    {
                        updating.Email = mail_update;
                    }
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        updating = db.users.Where(b => b.Login == profile_user_login).FirstOrDefault();
                        updating.Email = mail_update;
                        db.SaveChanges();
                    }
                    
                    MessageBox.Show("Почта изменена");
                    update_email.ToolTip = null;
                    update_email.BorderBrush = Brushes.Black;

                }


                
                } else
                {
                MessageBox.Show("Ничего не изменилось 🤨");
                }
        }

        private void plaster_check_Checked(object sender, RoutedEventArgs e)
        {
            check_plaster = true;
            plaster_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }

        private void plaster_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_plaster = false;
            plaster_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        private void grunt_check_Checked(object sender, RoutedEventArgs e)
        {
            check_grunt = true;
            grunt_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }

        private void grunt_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_grunt = false;
            grunt_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        private void ground_coat_check_Checked(object sender, RoutedEventArgs e)
        {
            check_ground_coat = true;
            ground_coat_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }

        private void ground_coat_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_ground_coat = false;
            ground_coat_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        private void paint_check_Checked(object sender, RoutedEventArgs e)
        {
            check_paint = true;
            paint_grid.Visibility = Visibility.Visible;
            adaptive_epta();
        }

        private void paint_check_Unchecked(object sender, RoutedEventArgs e)
        {
            check_paint = false;
            paint_grid.Visibility = Visibility.Hidden;
            adaptive_epta();
        }

        int type_calc_check = 0;
        //when type of calc changed
        private void Paint_calcs_combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            selected_type_of_calc = Convert.ToByte(paint_calcs_combobox.SelectedIndex + 1);
            //MessageBox.Show(selected_type_of_calc.ToString());
            //Thickness space_margin = space_grid.Margin;
            textblock_paint_result.Text = "Нажмите \"Рассчитать\"";
            switch (selected_type_of_calc)
            {
                case 1:
                    //space_grid.Margin = new Thickness(0, 300, 0, 0);
                    //textblock_paint_result.Margin = new Thickness(0, 115, 0, 0);
                    spaces_top = 100;
                    height2_grid.Visibility = Visibility.Hidden;
                    height3_grid.Visibility = Visibility.Hidden;
                    height4_grid.Visibility = Visibility.Hidden;
                    type_calc_check = 1;
                    if (first_here)
                    {
                        do_calculation.IsEnabled = true;
                    } else if (rooms) {
                        do_calculation.IsEnabled = false;
                    }
                    if (user_type != 3 && first_here || rooms) add_room_button.IsEnabled = true; 
                    else
                        add_room_button.IsEnabled = false;
                    first_here = false;
                    break;
                case 2:
                    type_calc_check = 2;
                    //space_grid.Margin = new Thickness(0, 345, 0, 0);
                    //textblock_paint_result.Margin = new Thickness(0, 160, 0, 0);
                    height2_grid.Visibility = Visibility.Visible;
                    height3_grid.Visibility = Visibility.Hidden;
                    height4_grid.Visibility = Visibility.Hidden;
                    spaces_top = 170;

                    if (first_here)
                    {
                        do_calculation.IsEnabled = true;
                    }
                    else if (rooms)
                    {
                        do_calculation.IsEnabled = false;
                    }
                    if (user_type != 3 && first_here || rooms) add_room_button.IsEnabled = true;
                    else
                        add_room_button.IsEnabled = false;
                    first_here = false;
                    break;
                case 3:
                    type_calc_check = 3;
                    height2_grid.Visibility = Visibility.Visible;
                    height3_grid.Visibility = Visibility.Visible;
                    height4_grid.Visibility = Visibility.Visible;
                    spaces_top = 170;
                    if (first_here)
                    {
                        do_calculation.IsEnabled = true;
                    }
                    else if (rooms)
                    {
                        do_calculation.IsEnabled = false;
                    }
                    if (user_type != 3 && first_here || rooms) add_room_button.IsEnabled = true;
                    else
                        add_room_button.IsEnabled = false;
                    first_here = false;
                    break;
                /*case 4:
                    type_calc_check = 4;
                    if (first_here)
                    {
                        do_calculation.IsEnabled = true;
                    }
                    else if (rooms)
                    {
                        do_calculation.IsEnabled = false;
                    }
                    if (user_type != 3 && first_here || rooms) add_room_button.IsEnabled = true;
                    else
                        add_room_button.IsEnabled = false;
                    first_here = false;
                    break;*/
            }
            space_grid.Margin = new Thickness(0, spaces_top, 190, 4);
        }
        // add space button
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            space_width = check_value(space_width_textbox.Text);
            space_height = check_value(space_height_textbox.Text);
            if (space_height > 0 && space_width > 0)
            {
                space_id++;
                space_square = space_width * space_height;
                space_listbox.Items.Add("Проем №" + space_id + ", Ширина - " + space_width + ", Высота - " + space_height + ", Площадь - " + space_square + " - " + measure_ln + "\u00B2");
                all_space_square += space_square;
            } else
            {
                warning_number_window();
            }
        }


        private void Space_history_listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Account_info_btn_Click(object sender, RoutedEventArgs e)
        {
            hide_profile(0);
            hide_menu2(1);
            update_login.Text = profile_user_login;
            update_email.Text = profile_user_mail;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void history_button_Click(object sender, RoutedEventArgs e)
        {
            admin_grid.Visibility = Visibility.Visible;
            hide_menu2(1);
            users_list_update();
        }

        private void delete_user_button_Click(object sender, RoutedEventArgs e)
        {
            var a = Int32.TryParse(deleted_user_id_textbox.Text.ToString(), out int value_1);
            if (a)
            {
                int delete_id = Math.Abs(Int32.Parse(deleted_user_id_textbox.Text.ToString()));
                user admin_stat = null;
                using (ApplicationContext db = new ApplicationContext())
                {
                    admin_stat = db.users.Where(b => b.id == delete_id).FirstOrDefault();
                }
                try
                {
                    if (admin_stat != null)
                    {

                        if (admin_stat.Admin_status != "true")
                        {
                            try
                            {
                                var input_del = db.users.FirstOrDefault(x => x.id == delete_id);
                                db.users.Remove(input_del);
                                db.SaveChanges();
                                users_list_update();
                            }
                            catch
                            {

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка");
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
            else
            {
                warning_number_window();
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            void Create(string filePath)
            {
                string calc_id, user_id, calc_type, an1, an2, an3, an4, w1, w2, l1, l2, h1, h2, h3, h4, space_square, date;
                string wall_square, ceiling_perimetr, ceiling_area, ground_area, ground_perimetr, height_length;
                List<input_paints> inputs;
                List<output_paints> outputs;
                List<materials> materials;
                if (user_type == 2)
                {
                    inputs = db.input_paint.ToList();
                    outputs = db.output_paint.ToList();
                    materials = db.material.ToList();
                }
                else
                {
                    inputs = db.input_paint.Where(b => b.User_id == current_user_id.ToString()).ToList();
                    outputs = db.output_paint.Where(b => b.User_id == current_user_id.ToString()).ToList();
                    materials = db.material.Where(b => b.User_id == current_user_id.ToString()).ToList();
                }

                string a_col = "A", b_col = "B", c_col = "C", d_col = "D", e_col = "E", f_col = "F", g_col = "G", h_col = "H";
                string i_col = "I", j_col = "J", k_col = "K", l_col = "L", m_col = "M", n_col = "N", o_col = "O", p_col = "P";
                string q_col = "Q", r_col = "R", s_col = "S", t_col = "T", u_col = "U", v_col = "V", w_col = "W", x_col = "X";
                int row_count = 2;

                var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add("Расчёты");

                var colu_a1 = ws.Column("A");
                var colu_b1 = ws.Column("B");
                var colu_c1 = ws.Column("C");
                var colu_d1 = ws.Column("D");
                var colu_e1 = ws.Column("E");
                var colu_f1 = ws.Column("F");
                var colu_g1 = ws.Column("G");
                var colu_h1 = ws.Column("H");
                var colu_i1 = ws.Column("I");
                var colu_j1 = ws.Column("J");
                var colu_k1 = ws.Column("K");
                var colu_l1 = ws.Column("L");
                var colu_m1 = ws.Column("M");
                var colu_n1 = ws.Column("N");
                var colu_o1 = ws.Column("O");
                var colu_p1 = ws.Column("P");
                var colu_q1 = ws.Column("Q");
                var colu_r1 = ws.Column("R");
                var colu_s1 = ws.Column("S");
                var colu_t1 = ws.Column("T");
                var colu_u1 = ws.Column("U");
                var colu_v1 = ws.Column("V");
                var colu_w1 = ws.Column("W");
                var colu_x1 = ws.Column("X");



                colu_a1.Width = 9; colu_b1.Width = 15; colu_c1.Width = 11; colu_d1.Width = 9; colu_e1.Width = 9; colu_f1.Width = 9;
                colu_g1.Width = 9; colu_h1.Width = 11; colu_i1.Width = 11; colu_j1.Width = 11; colu_k1.Width = 11; colu_l1.Width = 11;
                colu_m1.Width = 11; colu_n1.Width = 11; colu_o1.Width = 11; colu_p1.Width = 11; colu_q1.Width = 17;
                colu_r1.Width = 17; colu_s1.Width = 13; colu_t1.Width = 14; colu_u1.Width = 17; colu_v1.Width = 24; colu_w1.Width = 20; colu_x1.Width = 20;

                var rngTable1 = ws.Range("A1:X1");
                var rngHeaders1 = rngTable1.Range("A1:X1");
                rngHeaders1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders1.Style.Font.Bold = true;
                rngHeaders1.Style.Fill.BackgroundColor = XLColor.Aqua;

                var rngtable1 = ws.Range("A2:X200");
                var rngnumbers1 = rngtable1.Range("A2:X200");
                rngnumbers1.DataType = XLDataType.Number;
                rngnumbers1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                ws.Cell("A1").Value = "Id Расчета";
                ws.Cell("B1").Value = "Id Пользователя";
                ws.Cell("C1").Value = "Тип расчёта";
                ws.Cell("D1").Value = "Угол №1";
                ws.Cell("E1").Value = "Угол №2";
                ws.Cell("F1").Value = "Угол №3";
                ws.Cell("G1").Value = "Угол №4";
                ws.Cell("H1").Value = "Ширнина №1";
                ws.Cell("I1").Value = "Ширнина №2";
                ws.Cell("J1").Value = "Длина №1";
                ws.Cell("K1").Value = "Длина №2";
                ws.Cell("L1").Value = "Высота №1";
                ws.Cell("M1").Value = "Высота №2";
                ws.Cell("N1").Value = "Высота №3";
                ws.Cell("O1").Value = "Высота №4";
                ws.Cell("P1").Value = "Площадь стен";
                ws.Cell("Q1").Value = "Периметр потолка";
                ws.Cell("R1").Value = "Площадь потолка";
                ws.Cell("S1").Value = "Площадь пола";
                ws.Cell("T1").Value = "Периметр пола";
                ws.Cell("U1").Value = "Площадь проемов";
                ws.Cell("V1").Value = "Общая высота всех углов";
                ws.Cell("W1").Value = "Дата";
                ws.Cell("X1").Value = "Номер комнаты";


                foreach (input_paints input in inputs)
                {
                    int cur_id = input.id;
                    calc_id = cur_id.ToString();
                    user_id = current_user_id.ToString();
                    calc_type = input.Calc_type;
                    an1 = input.An1;
                    an2 = input.An2;
                    an3 = input.An3;
                    an4 = input.An4;
                    w1 = input.W1;
                    w2 = input.W2;
                    l1 = input.L1;
                    l2 = input.L2;
                    h1 = input.H1;
                    h2 = input.H2;
                    h3 = input.H3;
                    h4 = input.H4;
                    string h5 = input.Room_number;
                    space_square = input.Space_square;
                    date = input.Date;
                    int out_id;
                    string out_square = "0", out_square2 = "0";
                    foreach (output_paints output in outputs)
                    {

                        if (output.id == cur_id)
                        {
                            wall_square = output.Wall_square;
                            ceiling_perimetr = output.Ceiling_perimetr;
                            ceiling_area = output.Ceiling_area;
                            ground_area = output.Ground_area;
                            ground_perimetr = output.Ground_perimetr;
                            height_length = output.Height_lenght;

                            a_col += row_count.ToString();
                            b_col += row_count.ToString();
                            c_col += row_count.ToString();
                            d_col += row_count.ToString();
                            e_col += row_count.ToString();
                            f_col += row_count.ToString();
                            g_col += row_count.ToString();
                            h_col += row_count.ToString();
                            i_col += row_count.ToString();
                            j_col += row_count.ToString();
                            k_col += row_count.ToString();
                            l_col += row_count.ToString();
                            m_col += row_count.ToString();
                            n_col += row_count.ToString();
                            o_col += row_count.ToString();
                            p_col += row_count.ToString();
                            q_col += row_count.ToString();
                            r_col += row_count.ToString();
                            s_col += row_count.ToString();
                            t_col += row_count.ToString();
                            u_col += row_count.ToString();
                            v_col += row_count.ToString();
                            w_col += row_count.ToString();
                            x_col += row_count.ToString();

                            ws.Cell(a_col).Value = cur_id;
                            ws.Cell(b_col).Value = current_user_id;
                            ws.Cell(c_col).Value = calc_type;
                            ws.Cell(d_col).Value = an1;
                            ws.Cell(e_col).Value = an2;
                            ws.Cell(f_col).Value = an3;
                            ws.Cell(g_col).Value = an4;
                            ws.Cell(h_col).Value = w1;
                            ws.Cell(i_col).Value = w2;
                            ws.Cell(j_col).Value = l1;
                            ws.Cell(k_col).Value = l2;
                            ws.Cell(l_col).Value = h1;
                            ws.Cell(m_col).Value = h2;
                            ws.Cell(n_col).Value = h3;
                            ws.Cell(o_col).Value = h4;
                            ws.Cell(p_col).Value = wall_square;
                            ws.Cell(q_col).Value = ceiling_perimetr;
                            ws.Cell(r_col).Value = ceiling_area;
                            ws.Cell(s_col).Value = ground_area;
                            ws.Cell(t_col).Value = ground_perimetr;
                            ws.Cell(u_col).Value = space_square;
                            ws.Cell(v_col).Value = height_length;
                            ws.Cell(w_col).Value = date;
                            ws.Cell(x_col).Value = h5;
                            a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                            i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                            q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                            row_count++;
                        }
                    }

                    
                }
                a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                row_count = 2;
                var ws2 = wb.Worksheets.Add("Обои, Штукатурка");
                ws2.Cell("A1").Value = "Id Расчета";
                ws2.Cell("B1").Value = "Id Пользователя";
                ws2.Cell("C1").Value = "Ширина обоев";
                ws2.Cell("D1").Value = "Ширина рулона";
                ws2.Cell("E1").Value = "Длина обоев";
                ws2.Cell("F1").Value = "Кол-во рулонов";
                ws2.Cell("G1").Value = "Кол-во слоев штукатурки";
                ws2.Cell("H1").Value = "Вес емкости штукатурки";
                ws2.Cell("I1").Value = "Расход емкости";
                ws2.Cell("J1").Value = "Площадь расхода";
                ws2.Cell("K1").Value = "Вес емкостей";
                ws2.Cell("L1").Value = "Кол-во емкостей";
                //ws2.Cell("M1").Value = "Дата";
                var colu_a = ws2.Column("A");
                var colu_b = ws2.Column("B");
                var colu_c = ws2.Column("C");
                var colu_d = ws2.Column("D");
                var colu_e = ws2.Column("E");
                var colu_f = ws2.Column("F");
                var colu_g = ws2.Column("G");
                var colu_h = ws2.Column("H");
                var colu_i = ws2.Column("I");
                var colu_j = ws2.Column("J");
                var colu_k = ws2.Column("K");
                var colu_l = ws2.Column("L");

                var rngTable2 = ws2.Range("A1:L1");
                var rngHeaders2 = rngTable2.Range("A1:L1");
                rngHeaders2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders2.Style.Font.Bold = true;
                rngHeaders2.Style.Fill.BackgroundColor = XLColor.Aqua;

                var rngtable2 = ws2.Range("A2:W200");
                var rngnumbers2 = rngtable2.Range("A2:W200");
                rngnumbers2.DataType = XLDataType.Number;
                rngnumbers2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                colu_a.Width = 9; colu_b.Width = 14; colu_c.Width = 13; colu_d.Width = 13.5; colu_e.Width = 11; colu_f.Width = 13.5;
                colu_g.Width = 21.5; colu_h.Width = 20; colu_i.Width = 13.5; colu_j.Width = 15.3; colu_k.Width = 12; colu_l.Width = 15;


                foreach (materials material in materials)
                {
                    int cur_id2 = material.id;
                    calc_id = cur_id2.ToString();
                    user_id = current_user_id.ToString();
                    calc_type = material.In_wallpapers_width;
                    an1 = material.In_wallpapers_circle_length;
                    an2 = material.Wallpapers_length_m;
                    an3 = material.Wallpapers_amount;
                    an4 = material.In_plaster_thick;
                    w1 = material.In_plaster_kg_mesh;
                    w2 = material.In_plaster_m_mesh;
                    l1 = material.Plaster_volume_m;
                    l2 = material.Plaster_kg;
                    h1 = material.Plaster_amount;
                    //date = material.Date;
                    int out_id2;
                    //string out_square = "0", out_square2 = "0";


                    if (material.id == cur_id2)
                    {
                        /*wall_square = output.Wall_square;
                        ceiling_perimetr = output.Ceiling_perimetr;
                        ceiling_area = output.Ceiling_area;
                        ground_area = output.Ground_area;
                        ground_perimetr = output.Ground_perimetr;
                        height_length = output.Height_lenght;*/

                        a_col += row_count.ToString();
                        b_col += row_count.ToString();
                        c_col += row_count.ToString();
                        d_col += row_count.ToString();
                        e_col += row_count.ToString();
                        f_col += row_count.ToString();
                        g_col += row_count.ToString();
                        h_col += row_count.ToString();
                        i_col += row_count.ToString();
                        j_col += row_count.ToString();
                        k_col += row_count.ToString();
                        l_col += row_count.ToString();
                        //m_col += row_count.ToString();


                        ws2.Cell(a_col).Value = cur_id2;
                        ws2.Cell(b_col).Value = current_user_id;
                        ws2.Cell(c_col).Value = calc_type;
                        ws2.Cell(d_col).Value = an1;
                        ws2.Cell(e_col).Value = an2;
                        ws2.Cell(f_col).Value = an3;
                        ws2.Cell(g_col).Value = an4;
                        ws2.Cell(h_col).Value = w1;
                        ws2.Cell(i_col).Value = w2;
                        ws2.Cell(j_col).Value = l1;
                        ws2.Cell(k_col).Value = l2;
                        ws2.Cell(l_col).Value = h1;
                        //ws2.Cell(m_col).Value = date;h1;
                        


                        a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                        i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                        q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                        row_count++;
                    }
                }






                a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                row_count = 2;
                var ws3 = wb.Worksheets.Add("Грунтовка, Шпаклевка");
                ws3.Cell("A1").Value = "Id Расчета";
                ws3.Cell("B1").Value = "Id Пользователя";
                ws3.Cell("C1").Value = "кол-во слоев грунтовки";
                ws3.Cell("D1").Value = "вес емкости";
                ws3.Cell("E1").Value = "расход емкости";
                ws3.Cell("F1").Value = "площадь покрытия";
                ws3.Cell("G1").Value = "вес емкостей";
                ws3.Cell("H1").Value = "кол-во емкостей";
                ws3.Cell("I1").Value = "кол-во слоев шпаклевки";
                ws3.Cell("J1").Value = "вес емкости";
                ws3.Cell("K1").Value = "расход емкости";
                ws3.Cell("L1").Value = "площадь покрытия";
                ws3.Cell("M1").Value = "вес емкостей";
                ws3.Cell("N1").Value = "кол-во емкостей";
                //ws2.Cell("M1").Value = "Дата";
                var colu_a3 = ws3.Column("A");
                var colu_b3 = ws3.Column("B");
                var colu_c3 = ws3.Column("C");
                var colu_d3 = ws3.Column("D");
                var colu_e3 = ws3.Column("E");
                var colu_f3 = ws3.Column("F");
                var colu_g3 = ws3.Column("G");
                var colu_h3 = ws3.Column("H");
                var colu_i3 = ws3.Column("I");
                var colu_j3 = ws3.Column("J");
                var colu_k3 = ws3.Column("K");
                var colu_l3 = ws3.Column("L");
                var colu_m3 = ws3.Column("M");
                var colu_n3 = ws3.Column("N");

                var rngTable3 = ws3.Range("A1:N1");
                var rngHeaders3 = rngTable3.Range("A1:N1");
                rngHeaders3.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders3.Style.Font.Bold = true;
                rngHeaders3.Style.Fill.BackgroundColor = XLColor.Aqua;

                var rngtable3 = ws3.Range("A2:W200");
                var rngnumbers3 = rngtable3.Range("A2:W200");
                rngnumbers3.DataType = XLDataType.Number;
                rngnumbers3.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                colu_a3.Width = 9; colu_b3.Width = 14; colu_c3.Width = 20; colu_d3.Width = 11.5; colu_e3.Width = 14; colu_f3.Width = 16.5;
                colu_g3.Width = 12; colu_h3.Width = 15; colu_i3.Width = 22; colu_j3.Width = 11.5; colu_k3.Width = 14; colu_l3.Width = 17;
                colu_m3.Width = 12; colu_n3.Width = 15;


                foreach (materials material in materials)
                {
                    int cur_id2 = material.id;
                    calc_id = cur_id2.ToString();
                    user_id = current_user_id.ToString();
                    calc_type = material.In_grunt_layers;
                    an1 = material.In_grunt_kg_mesh;
                    an2 = material.In_grunt_m_mesh;
                    an3 = material.Grunt_volume_m;
                    an4 = material.Grunt_kg;
                    w1 = material.Grunt_amount;
                    w2 = material.In_ground_coat_thick;
                    l1 = material.In_ground_coat_kg_mesh;
                    l2 = material.In_ground_coat_m_mesh;
                    h1 = material.Ground_coat_volume_m;
                    h2 = material.Ground_coat_volume_kg;
                    h3 = material.Ground_coat_amount;

                    //date = material.Date;
                    int out_id2;
                    //string out_square = "0", out_square2 = "0";


                    if (material.id == cur_id2)
                    {
                        /*wall_square = output.Wall_square;
                        ceiling_perimetr = output.Ceiling_perimetr;
                        ceiling_area = output.Ceiling_area;
                        ground_area = output.Ground_area;
                        ground_perimetr = output.Ground_perimetr;
                        height_length = output.Height_lenght;*/

                        a_col += row_count.ToString();
                        b_col += row_count.ToString();
                        c_col += row_count.ToString();
                        d_col += row_count.ToString();
                        e_col += row_count.ToString();
                        f_col += row_count.ToString();
                        g_col += row_count.ToString();
                        h_col += row_count.ToString();
                        i_col += row_count.ToString();
                        j_col += row_count.ToString();
                        k_col += row_count.ToString();
                        l_col += row_count.ToString();
                        m_col += row_count.ToString();
                        n_col += row_count.ToString();

                        ws3.Cell(a_col).Value = cur_id2;
                        ws3.Cell(b_col).Value = current_user_id;
                        ws3.Cell(c_col).Value = calc_type;
                        ws3.Cell(d_col).Value = an1;
                        ws3.Cell(e_col).Value = an2;
                        ws3.Cell(f_col).Value = an3;
                        ws3.Cell(g_col).Value = an4;
                        ws3.Cell(h_col).Value = w1;
                        ws3.Cell(i_col).Value = w2;
                        ws3.Cell(j_col).Value = l1;
                        ws3.Cell(k_col).Value = l2;
                        ws3.Cell(l_col).Value = h1;
                        ws3.Cell(m_col).Value = h2;
                        ws3.Cell(n_col).Value = h3;
                        


                        a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                        i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                        q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                        row_count++;
                    }
                }






                a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                row_count = 2;
                var ws4 = wb.Worksheets.Add("Краска");
                ws4.Cell("A1").Value = "Id Расчета";
                ws4.Cell("B1").Value = "Id Пользователя";
                ws4.Cell("C1").Value = "кол-во слоев краски";
                ws4.Cell("D1").Value = "вес емкости";
                ws4.Cell("E1").Value = "расход емкости";
                ws4.Cell("F1").Value = "площадь покрытия";
                ws4.Cell("G1").Value = "вес емкостей";
                ws4.Cell("H1").Value = "кол-во емкостей";
                
                //ws2.Cell("M1").Value = "Дата";
                var colu_a4 = ws4.Column("A");
                var colu_b4 = ws4.Column("B");
                var colu_c4 = ws4.Column("C");
                var colu_d4 = ws4.Column("D");
                var colu_e4 = ws4.Column("E");
                var colu_f4 = ws4.Column("F");
                var colu_g4 = ws4.Column("G");
                var colu_h4 = ws4.Column("H");

                var rngtable4 = ws4.Range("A2:W200");
                var rngnumbers4 = rngtable4.Range("A2:W200");
                rngnumbers4.DataType = XLDataType.Number;
                rngnumbers4.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                var rngTable4 = ws4.Range("A1:H1");
                var rngHeaders4 = rngTable4.Range("A1:H1");
                rngHeaders4.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders4.Style.Font.Bold = true;
                rngHeaders4.Style.Fill.BackgroundColor = XLColor.Aqua;


                colu_a4.Width = 9; colu_b4.Width = 14; colu_c4.Width = 20; colu_d4.Width = 11.5; colu_e4.Width = 14; colu_f4.Width = 16.5;
                colu_g4.Width = 12; colu_h4.Width = 15; 


                foreach (materials material in materials)
                {
                    int cur_id2 = material.id;
                    calc_id = cur_id2.ToString();
                    user_id = current_user_id.ToString();
                    calc_type = material.In_paint_layers;
                    an1 = material.In_paint_kg_mesh;
                    an2 = material.In_paint_m_mesh;
                    an3 = material.Paint_volume_m;
                    an4 = material.Paint_kg;
                    w1 = material.Paint_amount;
                   
                    //date = material.Date;
                    int out_id2;
                    //string out_square = "0", out_square2 = "0";


                    if (material.id == cur_id2)
                    {
                        /*wall_square = output.Wall_square;
                        ceiling_perimetr = output.Ceiling_perimetr;
                        ceiling_area = output.Ceiling_area;
                        ground_area = output.Ground_area;
                        ground_perimetr = output.Ground_perimetr;
                        height_length = output.Height_lenght;*/

                        a_col += row_count.ToString();
                        b_col += row_count.ToString();
                        c_col += row_count.ToString();
                        d_col += row_count.ToString();
                        e_col += row_count.ToString();
                        f_col += row_count.ToString();
                        g_col += row_count.ToString();
                        h_col += row_count.ToString();
                        

                        ws4.Cell(a_col).Value = cur_id2;
                        ws4.Cell(b_col).Value = current_user_id;
                        ws4.Cell(c_col).Value = calc_type;
                        ws4.Cell(d_col).Value = an1;
                        ws4.Cell(e_col).Value = an2;
                        ws4.Cell(f_col).Value = an3;
                        ws4.Cell(g_col).Value = an4;
                        ws4.Cell(h_col).Value = w1;
                     



                        a_col = "A"; b_col = "B"; c_col = "C"; d_col = "D"; e_col = "E"; f_col = "F"; g_col = "G"; h_col = "H";
                        i_col = "I"; j_col = "J"; k_col = "K"; l_col = "L"; m_col = "M"; n_col = "N"; o_col = "O"; p_col = "P";
                        q_col = "Q"; r_col = "R"; s_col = "S"; t_col = "T"; u_col = "U"; v_col = "V"; w_col = "W"; x_col = "X";
                        row_count++;
                    }
                }
                wb.SaveAs(filePath);
                // Creating a new workbook
                /*var wb = new XLWorkbook();

                //Adding a worksheet
                var ws = wb.Worksheets.Add("Contacts");

                //Adding text
                //Title
                ws.Cell("B2").Value = "Contacts";
                //First Names
                ws.Cell("B3").Value = "FName";
                ws.Cell("B4").Value = "John";
                ws.Cell("B5").Value = "Hank";
                ws.Cell("B6").Value = "Dagny";
                //Last Names
                ws.Cell("C3").Value = "LName";
                ws.Cell("C4").Value = "Galt";
                ws.Cell("C5").Value = "Rearden";
                ws.Cell("C6").Value = "Taggart";

                //Adding more data types
                //Is an outcast?
                ws.Cell("D3").Value = "Outcast";
                ws.Cell("D4").Value = true;
                ws.Cell("D5").Value = false;
                ws.Cell("D6").Value = false;
                //Date of Birth
                ws.Cell("E3").Value = "DOB";
                ws.Cell("E4").Value = new DateTime(1919, 1, 21);
                ws.Cell("E5").Value = new DateTime(1907, 3, 4);
                ws.Cell("E6").Value = new DateTime(1921, 12, 15);
                //Income
                ws.Cell("F3").Value = "Income";
                ws.Cell("F4").Value = 2000;
                ws.Cell("F5").Value = 40000;
                ws.Cell("F6").Value = 10000;

                //Defining ranges
                //From worksheet
                var rngTable = ws.Range("B2:F6");
                //From another range
                var rngDates = rngTable.Range("E4:E6");
                var rngNumbers = rngTable.Range("F4:F6");

                //Formatting dates and numbers
                //Using a OpenXML's predefined formats
                rngDates.Style.NumberFormat.NumberFormatId = 15;
                //Using a custom format
                rngNumbers.Style.NumberFormat.Format = "$ #,##0";

                //Formatting headers
                var rngHeaders = rngTable.Range("B3:F3");
                rngHeaders.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rngHeaders.Style.Font.Bold = true;
                rngHeaders.Style.Fill.BackgroundColor = XLColor.Aqua;

                //Adding grid lines
                rngTable.Style.Border.BottomBorder = XLBorderStyleValues.Thin;

                //Format title cell
                rngTable.Cell(1, 1).Style.Font.Bold = true;
                rngTable.Cell(1, 1).Style.Fill.BackgroundColor = XLColor.CornflowerBlue;
                rngTable.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                //Merge title cells
                rngTable.Row(1).Merge(); // We could've also used: rngTable.Range("A1:E1").Merge()

                //Add thick borders
                rngTable.Style.Border.OutsideBorder = XLBorderStyleValues.Thick;

                // You can also specify the border for each side with:
                // rngTable.FirstColumn().Style.Border.LeftBorder = XLBorderStyleValues.Thick;
                // rngTable.LastColumn().Style.Border.RightBorder = XLBorderStyleValues.Thick;
                // rngTable.FirstRow().Style.Border.TopBorder = XLBorderStyleValues.Thick;
                // rngTable.LastRow().Style.Border.BottomBorder = XLBorderStyleValues.Thick;

                // Adjust column widths to their content
                ws.Columns(2, 6).AdjustToContents();

                //Saving the workbook
                */
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Таблица Excel |*.xlsx";
            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    string path2 = saveFileDialog.FileName;
                    Create(path2);

                } catch
                {
                    MessageBox.Show("Ошибка создания файла XSLS");
                }
                MessageBox.Show("Готово");
            }    
        }
        Boolean rooms = false;
        Boolean first_room = true;
        private void add_room_button_Click(object sender, RoutedEventArgs e)
        {
            rooms = true;
            if (first_room)
            {
                first_room = false;
            }
            else
            {
                room_number_export++;
            }
            calculation();
            do_calculation.IsEnabled = false;
        }

        private void finish_button_Click(object sender, RoutedEventArgs e)
        {
            rooms = false;
            room_number_export = 1;
            if (user_type != 3)
            {
                do_calculation.IsEnabled = true;
            }
        }

        // clear all textboxes button
        private void Clear_button_Click(object sender, RoutedEventArgs e)
        {
            space_id = 0;
            space_square = 0;
            all_space_square = 0;
            space_listbox.Items.Clear();
            textblock_paint_result.Text = "";
            width_textbox.Text = "";
            height_textbox.Text = "";
            length_textbox.Text = "";
            height2_textbox.Text = "";
            space_height_textbox.Text = "";
            space_width_textbox.Text = "";

        }
        // checkbox spaces in true position
        Boolean space_check_value;
        private void Spaces_check_Checked(object sender, RoutedEventArgs e)
        {
            space_grid.Visibility = Visibility.Visible;
            space_check_value = true;
        }
>>>>>>> Stashed changes
        // checkbox spaces in false position
        private void Spaces_check_Unchecked(object sender, RoutedEventArgs e)
        {
            space_grid.Visibility = Visibility.Hidden;
            space_id = 0;
            space_square = 0;
            all_space_square = 0;
            space_listbox.Items.Clear();
            space_height_textbox.Text = "0";
            space_width_textbox.Text = "0";
            space_check_value = false;
        }
        // registration form button
        private void Register_acc_btn_Click(object sender, RoutedEventArgs e)
        {
            register_grid.Visibility = Visibility.Visible;
            main_menu_grid.Visibility = Visibility.Hidden;
        }
        //registration button for check values and registrated new user
        private void Register_btn_Click(object sender, RoutedEventArgs e)
        {
            
            
            string register_user_login = registration_login.Text.Trim();
            string register_user_email = registration_email.Text.Trim().ToLower();
            string register_user_pass1 = registration_pass1.Password.Trim();
            string register_user_pass2 = registration_pass2.Password.Trim();
            string admin_status = "false";
            var md5 = MD5.Create();
            string pass_md5 = "300$";
            try
            {
                md5 = MD5.Create();
                pass_md5 = Convert.ToBase64String(md5.ComputeHash(Encoding.UTF8.GetBytes(register_user_pass1)));
            } catch
            {
                MessageBox.Show("Ошибка с MD5");
            }
            user login_check;
            using (ApplicationContext db = new ApplicationContext())
            {
                login_check = db.users.Where(b => b.Login == register_user_login).FirstOrDefault();
            }

            if (register_user_login.Length < 4)
            {
                registration_login.ToolTip = "Длина логина должна быть больше 4 символов";
                registration_login.BorderBrush = Brushes.Crimson;
            } else if (login_check != null) 
            {
                registration_login.ToolTip = "Пользователь с такми логином уже существует";
                registration_login.BorderBrush = Brushes.Crimson;
            } else
            {
                registration_login.ToolTip = null;
                registration_login.BorderBrush = Brushes.Black;
            }


            if (register_user_pass1.Length < 4)
            {
                registration_pass1.ToolTip = "Длина пароля должна быть больше 4 символов";
                registration_pass1.BorderBrush = Brushes.Crimson;
            } else
            {
                registration_pass1.ToolTip = null;
                registration_pass1.BorderBrush = Brushes.Black;
            }


            if (register_user_pass1 != register_user_pass2)
            {
                registration_pass1.ToolTip = "Пароли не совпадают";
                registration_pass1.BorderBrush = Brushes.Crimson;
                registration_pass2.ToolTip = "Пароли не совпадают";
                registration_pass2.BorderBrush = Brushes.Crimson;

            } else if (register_user_pass1.Length < 4)
            {
                
                registration_pass1.ToolTip = "Длина пароля должна быть больше 4 символов";
                registration_pass2.ToolTip = "Длина пароля должна быть больше 4 символов";
            } else
            {

                registration_pass1.ToolTip = null;
                registration_pass1.BorderBrush = Brushes.Black;
                registration_pass2.BorderBrush = Brushes.Black;
                registration_pass2.ToolTip = null;
            }


            if (register_user_email.Length < 5)
            {
                registration_email.ToolTip = "Длина почты должна быть больше 5 символов";
                registration_email.BorderBrush = Brushes.Crimson;
            } else
            {
                registration_email.ToolTip = null;
                registration_email.BorderBrush = Brushes.Black;
            }


            if (!register_user_email.Contains('@') || !register_user_email.Contains('.'))
            {
                registration_email.ToolTip = "Почта введена неправильно";
                registration_email.BorderBrush = Brushes.Crimson;
            } else if (register_user_email.Length < 5)
            {
                registration_email.ToolTip = "Длина почты должна быть больше 5 символов";
            } else
            {
                registration_email.ToolTip = null;
                registration_email.BorderBrush = Brushes.Black;
            }
            

            if (login_check == null && register_user_login.Length >= 4 && register_user_pass1.Length >= 4 && register_user_pass1 == register_user_pass2 && (register_user_email.Contains('@') && register_user_email.Contains('.')))
            {
                registration_email.ToolTip = null;
                registration_pass1.ToolTip = null;
                registration_pass2.ToolTip = null;
                registration_login.ToolTip = null;


                try
                {
                    user user = new user(register_user_login, register_user_email, pass_md5, admin_status);
                    db.users.Add(user);
                    db.SaveChanges();
                } 
                catch
                {
                    MessageBox.Show("Ошибка записи в бд");
                }
                
                register_grid.Visibility = Visibility.Hidden;
                main_menu_grid.Visibility = Visibility.Visible;
                MessageBox.Show("Регистрация проведена успешно");

                registration_login.Text = "";
                registration_email.Text = "";
                registration_pass1.Password = "";
                registration_pass2.Password = "";


            }
        }
        // function for check values in textboxes and login in account
        void login_account()
        {
            string user_login = login_textbox.Text.Trim();
            string user_pass = pass_textbox.Password.Trim();
            var md5 = MD5.Create();
            string pass_md5 = "300$";
            try
            {
                md5 = MD5.Create();
                pass_md5 = Convert.ToBase64String(md5.ComputeHash(Encoding.UTF8.GetBytes(user_pass)));
            }
            catch
            {
                MessageBox.Show("Ошибка с MD5");
            }

            if (user_login.Length < 4)
            {
                login_textbox.ToolTip = "Длина логина должна быть больше 4 символов";
                login_textbox.BorderBrush = Brushes.Crimson;
            }
            else
            {
                login_textbox.ToolTip = null;
                login_textbox.BorderBrush = Brushes.Black;
            }


            if (user_pass.Length < 4)
            {
                pass_textbox.ToolTip = "Длина пароля должна быть больше 4 символов";
                pass_textbox.BorderBrush = Brushes.Crimson;
            }
            else
            {
                pass_textbox.ToolTip = null;
                pass_textbox.BorderBrush = Brushes.Black;
            }
            if (user_login.Length >= 4 && user_pass.Length >= 4)
            {
                //string md5_pass = MD5.Create(user_pass).ToString();

                user authUser = null;
                //user user_id = null;
                using (ApplicationContext db = new ApplicationContext())
                {
                    authUser = db.users.Where(b => b.Login == user_login && b.Password == pass_md5).FirstOrDefault();
                }
                if (authUser != null)
                {
                    MessageBox.Show("Успешно!");
                    current_user_id = authUser.id;
                    //MessageBox.Show(user_id);
                    if (authUser.Admin_status == "true")
                    {
                        user_type = 2;
                        history_button.IsEnabled = true; //admin panel
                    }
                    else
                    {
                        user_type = 1;
                        history_button.IsEnabled = false; //admin panel
                    }
                    history_btn.IsEnabled = true;
                    account_info_btn.IsEnabled = true;
                    profile_user_mail = authUser.Email;
                    profile_user_login = authUser.Login;
                    grid_menu.Visibility = Visibility.Visible;
                    main_menu_grid.Visibility = Visibility.Hidden;
                    add_room_button.IsEnabled = true;
                    login_textbox.Text = "";
                    pass_textbox.Password = "";
                    textblock_paint_result.Text = "Выберете \"Тип расчёта\"";
                }
                else
                {
                    user_type = 0;
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }
        private void Login_btn_Click(object sender, RoutedEventArgs e)
        {
            login_account();
        }
        private MediaPlayer player = new MediaPlayer();
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            new About1().ShowDialog();
        }
        // login form button
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            register_grid.Visibility = Visibility.Hidden;
            main_menu_grid.Visibility = Visibility.Visible;
        }
        // exit button
        private void Exit_account_btn_Click(object sender, RoutedEventArgs e)
        {
            add_room_button.IsEnabled = false;
            //do_calculation.IsEnabled = false;
            admin_grid.Visibility = Visibility.Hidden;
            register_grid.Visibility = Visibility.Hidden;
            grid_menu.Visibility = Visibility.Hidden;
            history_grid.Visibility = Visibility.Hidden;
          //grid_paint_calc.Visibility = Visibility.Hidden;
          //paint_options_grid.Visibility = Visibility.Hidden;
          //space_grid.Visibility = Visibility.Hidden;
            main_menu_grid.Visibility = Visibility.Visible;
            hide_menu2(1);
            hide_paint_calc(1);
            hide_profile(1);
            user_type = 0;
            current_user_id = 1;
            
        }
        //when press "enter button" in login form
        private void login_key_enter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                login_account();
            }
        }
        void hide_menu2(int i)
        {
            if (i == 1)
            {
                menu2_grid.Visibility = Visibility.Hidden;
            } else
            {
                menu2_grid.Visibility = Visibility.Visible;
            }
            
        }
        void hide_paint_calc(int i)
        {
            if (i == 1)
            {
                grid_paint_calc.Visibility = Visibility.Hidden;
                paint_options_grid.Visibility = Visibility.Hidden;
                space_grid.Visibility = Visibility.Hidden;
                

            } else
            {
                grid_paint_calc.Visibility = Visibility.Visible;
                paint_options_grid.Visibility = Visibility.Visible;
                if (space_check_value)
                {
                    space_grid.Visibility = Visibility.Visible;
                }
                else
                {
                    space_grid.Visibility = Visibility.Hidden;
                }
            }
        }
        void hide_history_calc(int i)
        {
            if (i == 1)
            {
                history_grid.Visibility = Visibility.Hidden;
            }
            else
            {
                history_grid.Visibility = Visibility.Visible;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            }
        }
        void hide_profile(int i)
        {
            if (i > 0)
            {
                profile_grid1.Visibility = Visibility.Hidden;
            }
            else
            {
                profile_grid1.Visibility = Visibility.Visible;
            }
        }
=======
            }
        }
        void hide_profile(int i)
        {
            if (i > 0)
            {
                profile_grid1.Visibility = Visibility.Hidden;
            }
            else
            {
                profile_grid1.Visibility = Visibility.Visible;
            }
        }
>>>>>>> Stashed changes
=======
            }
        }
        void hide_profile(int i)
        {
            if (i > 0)
            {
                profile_grid1.Visibility = Visibility.Hidden;
            }
            else
            {
                profile_grid1.Visibility = Visibility.Visible;
            }
        }
>>>>>>> Stashed changes
        void hide_all_pages()
        {
            hide_paint_calc(1);
        }
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }
}
