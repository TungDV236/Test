using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using IOPath = System.IO.Path;
using System.Windows.Shapes;
using System.Windows.Input;
using System.Windows.Threading;
using Newtonsoft.Json;
using System.Windows.Media;
using System.Text.Json;
using MaterialDesignThemes.Wpf;
using Machine_Cut_Via.Class;
using static MaterialDesignThemes.Wpf.Theme.ToolBar;
using static Machine_Cut_Via.LoginWindow;
using System.Windows.Markup;
using System.Xml.Linq;


namespace Machine_Cut_Via.Class
{

    public class List_Error
    {
        public int STT { get; set; }
        public string Code { get; set; }
        public string Content_ { get; set; }
        public string Solution { get; set; }
        public string Time { get; set; }
    }


    public class List_Error_temp
    {
        public int STT { get; set; }
        public string Code { get; set; }
        public string Content_ { get; set; }
        public string Solution { get; set; }
        public string Time { get; set; }

    }
    public class List_Err
    {
        public int STT { get; set; }
        public string Code { get; set; }
        public string Content_ { get; set; }
        public string Solution { get; set; }
        public string Time { get; set; }

    }
    public class History_UL

    {

        public static bool E11;
        public static bool E12;
        public static bool E13;
        public static bool E14;
        public static bool E15;
        public static bool E16;
        public static bool E17;
        public static bool E18;
        public static bool E19;
        public static bool E1A;
        public static bool E1B;
        public static bool E1C;
        public static bool E1D;
        public static bool E1E;
        public static bool E1F;
        //
        public static bool E21;
        public static bool E22;
        public static bool E23;
        public static bool E24;
        public static bool E25;
        public static bool E26;
        public static bool E27;
        public static bool E28;
        public static bool E29;
        public static bool E2A;
        public static bool E2B;
        public static bool E2C;
        public static bool E2D;
        public static bool E2E;
        public static bool E2F;
        //
        public static bool E31;
        public static bool E32;
        public static bool E33;
        public static bool E34;
        public static bool E35;
        public static bool E36;
        public static bool E37;
        public static bool E38;
        public static bool E39;
        public static bool E3A;
        public static bool E3B;
        public static bool E3C;
        public static bool E3D;
        public static bool E3E;
        public static bool E3F;
        //
        public static bool E41;
        public static bool E42;
        public static bool E43;
        public static bool E44;
        public static bool E45;
        public static bool E46;
        public static bool E47;
        public static bool E48;
        public static bool E49;
        public static bool E4A;
        public static bool E4B;
        public static bool E4C;
        public static bool E4D;
        public static bool E4E;
        public static bool E4F;

        public static bool A11;
        public static bool A12;
        public static bool A13;
        public static bool A14;
        public static bool A15;
        public static bool A16;
        public static bool A17;
        public static bool A18;
        public static bool A19;
        public static bool A1A;
        public static bool A1B;
        public static bool A1C;
        public static bool A1D;
        public static bool A1E;
        public static bool A1F;
        //                 
        public static bool A21;
        public static bool A22;
        public static bool A23;
        public static bool A24;
        public static bool A25;
        public static bool A26;
        public static bool A27;
        public static bool A28;
        public static bool A29;
        public static bool A2A;
        public static bool A2B;
        public static bool A2C;
        public static bool A2D;
        public static bool A2E;
        public static bool A2F;
        //                 
        public static bool A31;
        public static bool A32;
        public static bool A33;
        public static bool A34;
        public static bool A35;
        public static bool A36;
        public static bool A37;
        public static bool A38;
        public static bool A39;
        public static bool A3A;
        public static bool A3B;
        public static bool A3C;
        public static bool A3D;
        public static bool A3E;
        public static bool A3F;
        //                 
        public static bool A41;
        public static bool A42;
        public static bool A43;
        public static bool A44;
        public static bool A45;
        public static bool A46;
        public static bool A47;
        public static bool A48;
        public static bool A49;
        public static bool A4A;
        public static bool A4B;
        public static bool A4C;
        public static bool A4D;
        public static bool A4E;
        public static bool A4F;


        private static ushort _value;
        Link_Path linkpath = new Link_Path();





        public ushort Value
        {
            get => _value;
            set
            {
                // Kiểm tra xem giá trị đã thay đổi chưa
                if (_value != value)
                {
                    // Tính toán bit đã thay đổi
                    ushort changedBits = (ushort)(_value ^ value);
                    OnValueChanged(changedBits);
                    _value = value;
                }
            }
        }

        public event Action<ushort> ValueChanged;

        protected virtual void OnValueChanged(ushort changedBits)
        {
            ValueChanged?.Invoke(changedBits);
        }
        public void Main()
        {
            var observableWord = new History_UL();
            string code_E;
            ushort word;
            //        
            // Đăng ký sự kiện
            observableWord.ValueChanged += changedBits =>
            {
                //  Console.WriteLine("Giá trị đã thay đổi!");
                for (int i = 0; i < 16; i++)
                {
                    if ((changedBits & (1 << i)) != 0)

                    {
                        if ((Value & (1 << i)) != 0) // Giá trị hiện tại của bit
                        {
                            //   code_E = Choose_Data(i);
                            //   Console.WriteLine(" ma loi: " + code_E + "da xu ly");
                            //   Clear_History(code_E);
                            // AddErr(code_E);
                        }
                        else
                        {

                            // code_E = Choose_Data(i);
                            //  Console.WriteLine(" ma loi: " + code_E + "ton tai");
                            // Save_History(code_E);
                        }

                    }


                }
            };

            // Thay đổi giá trị
            observableWord.Value = word;
        }
        public static string Choose_Data(int i)
        {
            switch (i)
            {

                case 0:
                    return "E10";
                case 1:
                    return "E11";
                case 2:
                    return "E12";
                case 3:
                    return "E13";
                case 4:
                    return "E14";
                case 5:
                    return "E15";
                case 6:
                    return "E16";
                case 7:
                    return "E17";
                case 8:
                    return "E18";
                case 9:
                    return "E19";
                case 10:
                    return "E1A";
                case 11:
                    return "E1B";
                case 12:
                    return "E1C";
                case 13:
                    return "E1D";
                case 14:
                    return "E1E";
                case 15:
                    return "E1F";
                default:
                    return "Invalid option";
            }
        }


        private void Clear_History(string code_E)
        {



            string json = File.ReadAllText(linkpath.Error);
            var options = new JsonSerializerOptions { ReadCommentHandling = JsonCommentHandling.Skip };
            var data = System.Text.Json.JsonSerializer.Deserialize<List_Error_temp[]>(json, options);

            var newData = new List<List_Error_temp>();

            foreach (var item in data)
            {
                if (item.Code != code_E)
                {
                    newData.Add(item);
                }
            }
            var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            string newJsonString = System.Text.Json.JsonSerializer.Serialize(newData, jsonOptions);
            // Write back to file
            File.WriteAllText(linkpath.Error, newJsonString);
            //    Common.Load_View_Model(List_History_);


        }
        private void Save_History(string code_E)
        {
            //            if (float.Parse(txb_Speed_Step2.Text) >= 3 && float.Parse(txb_Speed_Step2.Text) <= 20)
            //          {
            System.DateTime dateTime = System.DateTime.Now;
            History_Error history_Error = new History_Error();
            List_Error List_His_Error = new List_Error();
            string Fill_json = File.ReadAllText(linkpath.History);
            //   string json_ = File.ReadAllText(linkpath.Error);
            string json = File.ReadAllText(linkpath.Error);
            int cnt = 0;
            if (Fill_json.Length > 0)
            {
                JArray json_fillArray = JArray.Parse(Fill_json);
                foreach (JObject obj in json_fillArray)
                {
                    if ((string)obj["Code"] == code_E)
                    {
                        List_His_Error.Code = (string)obj["Code"];
                        List_His_Error.Content_ = (string)obj["Content_"];
                        List_His_Error.Solution = (string)obj["Solution"];
                        List_His_Error.Time = dateTime.ToString();

                        string list_History_Json = JsonConvert.SerializeObject(List_His_Error);
                        // MessageBox.Show("Đã đọc được lỗi");
                        //   JArray json_Array = JArray.Parse(json);
                        var options = new JsonSerializerOptions { ReadCommentHandling = JsonCommentHandling.Skip };
                        var data = System.Text.Json.JsonSerializer.Deserialize<List_Error_temp[]>(json, options);
                        foreach (var item in data)
                        {
                            if (item.Code == code_E)
                            {
                                cnt += 1;
                            }
                        }
                        if (cnt == 0)
                        {
                            if (json.Length < 50)
                            {

                                json = json.Remove(json.Length - 1);
                                json = json + list_History_Json + "]";
                                File.WriteAllText(linkpath.Error, json);
                                cnt = 0;
                            }
                            else
                            {
                                json = json.Remove(json.Length - 1);
                                json = json + "," + list_History_Json + "]";
                                File.WriteAllText(linkpath.Error, json);
                                cnt = 0;
                            }

                        }

                    }
                }
            }
        }







    }
}
