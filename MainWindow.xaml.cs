using System;
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

namespace Price
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void ProductID_TextChanged(object sender, TextChangedEventArgs e)
        {
            String Productid1 = ProductID1.Text;
            String Productid2 = ProductID2.Text;
            String Productid3 = ProductID3.Text;
            String Productid4 = ProductID4.Text;
            String Productid5 = ProductID5.Text;
            String Productid6 = ProductID6.Text;




            if (Productid1 != "")
            {
                if (Productid1 == "A101")
                {
                    ProductName1.Text = "Apple";
                }
                if (Productid1 == "B102")
                {
                    ProductName1.Text = "Mango";
                }
                if (Productid1 == "C103")
                {
                    ProductName1.Text = "Papaya";
                }
                if (Productid1 == "D104")
                {
                    ProductName1.Text = "Orange";
                }
                if (Productid1 == "E105")
                {
                    ProductName1.Text = "Dragon Fruit";
                }
                if (Productid1 == "F106")
                {
                    ProductName1.Text = "Avacado";
                }
            }
            if (Productid2 != "")
            {
                if (Productid2 == "A101")
                {
                    ProductName2.Text = "Apple";
                }
                if (Productid2 == "B102")
                {
                    ProductName2.Text = "Mango";
                }
                if (Productid2 == "C103")
                {
                    ProductName2.Text = "Papaya";
                }
                if (Productid2 == "D104")
                {
                    ProductName2.Text = "Orange";
                }
                if (Productid2 == "E105")
                {
                    ProductName2.Text = "Dragon Fruit";
                }
                if (Productid2 == "F106")
                {
                    ProductName2.Text = "Avacado";
                }
            }
            if (Productid3 != "")
            {
                if (Productid3 == "A101")
                {
                    ProductName3.Text = "Apple";
                }
                if (Productid3 == "B102")
                {
                    ProductName3.Text = "Mango";
                }
                if (Productid3 == "C103")
                {
                    ProductName3.Text = "Papaya";
                }
                if (Productid3 == "D104")
                {
                    ProductName3.Text = "Orange";
                }
                if (Productid3 == "E105")
                {
                    ProductName3.Text = "Dragon Fruit";
                }
                if (Productid3 == "F106")
                {
                    ProductName3.Text = "Avacado";
                }
            }
            if (Productid4 != "")
            {
                if (Productid4 == "A101")
                {
                    ProductName4.Text = "Apple";
                }
                if (Productid4 == "B102")
                {
                    ProductName4.Text = "Mango";
                }
                if (Productid4 == "C103")
                {
                    ProductName4.Text = "Papaya";
                }
                if (Productid4 == "D104")
                {
                    ProductName4.Text = "Orange";
                }
                if (Productid4 == "E105")
                {
                    ProductName4.Text = "Dragon Fruit";
                }
                if (Productid4 == "F106")
                {
                    ProductName4.Text = "Avacado";
                }
            }
            if (Productid5 != "")
            {
                if (Productid5 == "A101")
                {
                    ProductName5.Text = "Apple";
                }
                if (Productid5 == "B102")
                {
                    ProductName5.Text = "Mango";
                }
                if (Productid5 == "C103")
                {
                    ProductName5.Text = "Papaya";
                }
                if (Productid5 == "D104")
                {
                    ProductName5.Text = "Orange";
                }
                if (Productid5 == "E105")
                {
                    ProductName5.Text = "Dragon Fruit";
                }
                if (Productid5 == "F106")
                {
                    ProductName5.Text = "Avacado";
                }
            }
            if (Productid6 != "")
            {
                if (Productid6 == "A101")
                {
                    ProductName6.Text = "Apple";
                }
                if (Productid6 == "B102")
                {
                    ProductName6.Text = "Mango";
                }
                if (Productid6 == "C103")
                {
                    ProductName6.Text = "Papaya";
                }
                if (Productid6 == "D104")
                {
                    ProductName6.Text = "Orange";
                }
                if (Productid6 == "E105")
                {
                    ProductName6.Text = "Dragon Fruit";
                }
                if (Productid6 == "F106")
                {
                    ProductName6.Text = "Avacado";
                }
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int PriceA = Convert.ToInt32(TotalPrice1.Text);
            int PriceB = Convert.ToInt32(TotalPrice2.Text);
            int PriceC = Convert.ToInt32(TotalPrice3.Text);
            int PriceD = Convert.ToInt32(TotalPrice4.Text);
            int PriceE = Convert.ToInt32(TotalPrice5.Text);
            int PriceF = Convert.ToInt32(TotalPrice6.Text);

            int Final = PriceA + PriceB + PriceC + PriceD +PriceE+PriceF;
            TotalPrice.Text = Final.ToString();
        }

        private void Quantity_TextChanged(object sender, TextChangedEventArgs e)
        {
            int QuantityA = Convert.ToInt32(Quantity1.Text.ToString());

            if (ProductName1.Text != "")
            {
                if (ProductName1.Text == "Apple")
                {
                    int PriceA = QuantityA * 36;

                    Price1.Text = PriceA.ToString();
                }
                if (ProductName1.Text == "Mango")
                {
                    int PriceB = QuantityA * 23;

                    Price1.Text = PriceB.ToString();
                }
                if (ProductName1.Text == "Avacado")
                {
                    int PriceC = QuantityA * 56;

                    Price1.Text = PriceC.ToString();
                }
                if (ProductName1.Text == "Papaya")
                {
                    int PriceD = QuantityA * 40;

                    Price1.Text = PriceD.ToString();
                }
                if (ProductName1.Text == "Dragon Fruit")
                {
                    int PriceE = QuantityA * 75;

                    Price1.Text = PriceE.ToString();
                }
                if (ProductName1.Text == "Orange")
                {
                    int PriceF = QuantityA * 32;

                    Price1.Text = PriceF.ToString();
                }
            }
        }

        private void Quantity2_TextChanged(object sender, TextChangedEventArgs e)
        {
            int QuantityB = Convert.ToInt32(Quantity2.Text.ToString());
            if (ProductName2.Text != "")
            {

                if (ProductName2.Text == "Apple")
                {
                    int PriceA1 = QuantityB * 36;

                    Price2.Text = PriceA1.ToString();
                }
                if (ProductName2.Text == "Mango")
                {
                    int PriceB1 = QuantityB * 23;

                    Price2.Text = PriceB1.ToString();
                }
                if (ProductName2.Text == "Avacado")
                {
                    int PriceC1 = QuantityB * 56;

                    Price2.Text = PriceC1.ToString();
                }
                if (ProductName2.Text == "Papaya")
                {
                    int PriceD1 = QuantityB * 40;

                    Price2.Text = PriceD1.ToString();
                }
                if (ProductName2.Text == "Dragon Fruit")
                {
                    int PriceE1 = QuantityB * 75;

                    Price2.Text = PriceE1.ToString();
                }
                if (ProductName2.Text == "Orange")
                {
                    int PriceF1 = QuantityB * 32;

                    Price2.Text = PriceF1.ToString();
                }
            }
        }

        private void Quantity3_TextChanged(object sender, TextChangedEventArgs e)
        {
            int QuantityC = Convert.ToInt32(Quantity3.Text.ToString());

            if (ProductName3.Text != "")
            {
                if (ProductName3.Text == "Apple")
                {
                    int Price = QuantityC * 36;

                    Price3.Text = Price.ToString();
                }
                if (ProductName3.Text == "Mango")
                {
                    int Price = QuantityC * 23;

                    Price3.Text = Price.ToString();
                }
                if (ProductName3.Text == "Avacado")
                {
                    int Price = QuantityC * 56;

                    Price3.Text = Price.ToString();
                }
                if (ProductName3.Text == "Papaya")
                {
                    int Price = QuantityC * 40;

                    Price3.Text = Price.ToString();
                }
                if (ProductName3.Text == "Dragon Fruit")
                {
                    int Price = QuantityC * 75;

                    Price3.Text = Price.ToString();
                }
                if (ProductName3.Text == "Orange")
                {
                    int Price = QuantityC * 32;

                    Price3.Text = Price.ToString();
                }
            }
        }

        private void Quantity4_TextChanged(object sender, TextChangedEventArgs e)
        {

            int QuantityD = Convert.ToInt32(Quantity4.Text.ToString());


            if (ProductName4.Text != "")
            {
                if (ProductName4.Text == "Apple")
                {
                    int Price = QuantityD * 36;

                    Price4.Text = Price.ToString();
                }
                if (ProductName4.Text == "Mango")
                {
                    int Price = QuantityD * 23;

                    Price4.Text = Price.ToString();
                }
                if (ProductName4.Text == "Avacado")
                {
                    int Price = QuantityD * 56;

                    Price4.Text = Price.ToString();
                }
                if (ProductName4.Text == "Papaya")
                {
                    int Price = QuantityD * 40;

                    Price4.Text = Price.ToString();
                }
                if (ProductName4.Text == "Dragon Fruit")
                {
                    int Price = QuantityD * 75;

                    Price4.Text = Price.ToString();
                }
                if (ProductName4.Text == "Orange")
                {
                    int Price = QuantityD * 32;

                    Price4.Text = Price.ToString();
                }
            }

        }

        private void Quantity5_TextChanged(object sender, TextChangedEventArgs e)
        {
            int QuantityE = Convert.ToInt32(Quantity5.Text.ToString());

            if (ProductName5.Text != "")
            {
                if (ProductName5.Text == "Apple")
                {
                    int Price = QuantityE * 36;

                    Price5.Text = Price.ToString();
                }
                if (ProductName5.Text == "Mango")
                {
                    int Price = QuantityE * 23;

                    Price5.Text = Price.ToString();
                }
                if (ProductName5.Text == "Avacado")
                {
                    int Price = QuantityE * 56;

                    Price5.Text = Price.ToString();
                }
                if (ProductName5.Text == "Papaya")
                {
                    int Price = QuantityE * 40;

                    Price5.Text = Price.ToString();
                }
                if (ProductName5.Text == "Dragon Fruit")
                {
                    int Price = QuantityE * 75;

                    Price5.Text = Price.ToString();
                }
                if (ProductName5.Text == "Orange")
                {
                    int Price = QuantityE * 32;

                    Price5.Text = Price.ToString();
                }

            }
        }

        private void Quantity6_TextChanged(object sender, TextChangedEventArgs e)
        {
            int QuantityF = Convert.ToInt32(Quantity6.Text.ToString());
            if (ProductName6.Text != "")
            {

                if (ProductName6.Text == "Apple")
                {
                    int Price = QuantityF * 36;

                    Price6.Text = Price.ToString();
                }
                if (ProductName6.Text == "Mango")
                {
                    int Price = QuantityF * 23;

                    Price6.Text = Price.ToString();
                }
                if (ProductName6.Text == "Avacado")
                {
                    int Price = QuantityF * 56;

                    Price6.Text = Price.ToString();
                }
                if (ProductName6.Text == "Papaya")
                {
                    int Price = QuantityF * 40;

                    Price6.Text = Price.ToString();
                }
                if (ProductName6.Text == "Dragon Fruit")
                {
                    int Price = QuantityF * 75;

                    Price6.Text = Price.ToString();
                }
                if (ProductName6.Text == "Orange")
                {
                    int Price = QuantityF * 32;

                    Price6.Text = Price.ToString();
                }
            }
        }

        private void Discount1_TextChanged(object sender, TextChangedEventArgs e)
        {
            int PriceA = Convert.ToInt32(Price1.Text);

            if (Price1.Text != "")
            {
                int DiscountA = Convert.ToInt32(Discount1.Text);
                int Final = PriceA - DiscountA;
                TotalPrice1.Text = Final.ToString();
            }

        }


        private void Discount2_TextChanged(object sender, TextChangedEventArgs e)
        {
            int PriceB = Convert.ToInt32(Price2.Text);
            int DiscountB = Convert.ToInt32(Discount2.Text);
            if (Price1.Text != "")
            {

                int Final = PriceB - DiscountB;
                TotalPrice2.Text = Final.ToString();
            }
        }

        private void Discount3_TextChanged(object sender, TextChangedEventArgs e)
        {
            int PriceC = Convert.ToInt32(Price3.Text);
            int DiscountC = Convert.ToInt32(Discount3.Text);
            if (Price1.Text != "")
            {

                int Final = PriceC - DiscountC;
                TotalPrice3.Text = Final.ToString();
            }
        }

        private void Discount4_TextChanged(object sender, TextChangedEventArgs e)
        {
            int PriceD = Convert.ToInt32(Price4.Text);
            int DiscountD = Convert.ToInt32(Discount4.Text);
            if (Price1.Text != "")
            {

                int Final = PriceD - DiscountD;
                TotalPrice4.Text = Final.ToString();
            }
        }

        private void Discount5_TextChanged(object sender, TextChangedEventArgs e)
        {
            int PriceE = Convert.ToInt32(Price5.Text);
            int DiscountE = Convert.ToInt32(Discount5.Text);
            if (Price1.Text != "")
            {

                int Final = PriceE - DiscountE;
                TotalPrice5.Text = Final.ToString();
            }
        }

        private void Discount6_TextChanged(object sender, TextChangedEventArgs e)
        {
            int PriceF = Convert.ToInt32(Price6.Text);
            int DiscountF = Convert.ToInt32(Discount6.Text);
            if (Price1.Text != "")
            {

                int Final = PriceF - DiscountF;
                TotalPrice6.Text = Final.ToString();
            }
        }
    }
}
    

