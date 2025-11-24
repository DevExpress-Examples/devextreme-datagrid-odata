namespace ODataServer.Models
{
    static class SampleData
    {
        public static List<Product> Products = [
            new Product {
                Product_ID = 1,
                Product_Name = "HD Video Player",
                Product_Production_Start = new DateTime(2013, 10, 7, 16, 0, 0),
                Product_Available = true,
                Product_Current_Inventory = 225,
                Product_Cost = 110.00,
                Product_Sale_Price = 220.00,
                Product_Retail_Price = 330.00,
                Product_Consumer_Rating = 4,
                Product_Category = "Video Players"
            },
            new Product {
                Product_ID = 2,
                Product_Name = "SuperHD Video Player",
                Product_Production_Start = new DateTime(2013, 12, 1, 0, 30, 0),
                Product_Available = true,
                Product_Current_Inventory = 150,
                Product_Cost = 175.00,
                Product_Sale_Price = 275.00,
                Product_Retail_Price = 400.00,
                Product_Consumer_Rating = 4,
                Product_Category = "Video Players"
            },
            new Product {
                Product_ID = 3,
                Product_Name = "SuperPlasma 50",
                Product_Production_Start = new DateTime(2005, 1, 10, 12, 45, 0),
                Product_Available = false,
                Product_Current_Inventory = 0,
                Product_Cost = 1100.00,
                Product_Sale_Price = 1800.00,
                Product_Retail_Price = 2400.00,
                Product_Consumer_Rating = 4.5,
                Product_Category = "Televisions"
            },
            new Product {
                Product_ID = 4,
                Product_Name = "SuperLED 50",
                Product_Production_Start = new DateTime(2011, 10, 30, 8, 30, 0),
                Product_Available = true,
                Product_Current_Inventory = 77,
                Product_Cost = 775.00,
                Product_Sale_Price = 1100.00,
                Product_Retail_Price = 1600.00,
                Product_Consumer_Rating = 5,
                Product_Category = "Televisions"
            },
            new Product {
                Product_ID = 5,
                Product_Name = "SuperLED 42",
                Product_Production_Start = new DateTime(2012, 9, 15, 8, 0, 0),
                Product_Available = true,
                Product_Current_Inventory = 445,
                Product_Cost = 675.00,
                Product_Sale_Price = 1050.00,
                Product_Retail_Price = 1450.00,
                Product_Consumer_Rating = 5,
                Product_Category = "Televisions"
            },
            new Product {
                Product_ID = 6,
                Product_Name = "SuperLCD 55",
                Product_Production_Start = new DateTime(2010, 8, 1, 15, 0, 0),
                Product_Available = true,
                Product_Current_Inventory = 345,
                Product_Cost = 745.00,
                Product_Sale_Price = 1045.00,
                Product_Retail_Price = 1350.00,
                Product_Consumer_Rating = 4.5,
                Product_Category = "Televisions"
            },
            new Product {
                Product_ID = 7,
                Product_Name = "SuperLCD 42",
                Product_Production_Start = new DateTime(2010, 7, 1, 20, 30, 0),
                Product_Available = true,
                Product_Current_Inventory = 210,
                Product_Cost = 710.00,
                Product_Sale_Price = 999.00,
                Product_Retail_Price = 1200.00,
                Product_Consumer_Rating = 4,
                Product_Category = "Televisions"
            },
            new Product {
                Product_ID = 8,
                Product_Name = "SuperPlasma 65",
                Product_Production_Start = new DateTime(2008, 12, 1, 0, 0, 0),
                Product_Available = false,
                Product_Current_Inventory = 0,
                Product_Cost = 1800.00,
                Product_Sale_Price = 2900.00,
                Product_Retail_Price = 3500.00,
                Product_Consumer_Rating = 3,
                Product_Category = "Televisions"
            },
            new Product {
                Product_ID = 9,
                Product_Name = "SuperLCD 70",
                Product_Production_Start = new DateTime(2012, 6, 1, 0, 0, 0),
                Product_Available = true,
                Product_Current_Inventory = 95,
                Product_Cost = 2125.00,
                Product_Sale_Price = 3200.00,
                Product_Retail_Price = 4000.00,
                Product_Consumer_Rating = 4,
                Product_Category = "Televisions"
            },
            new Product {
                Product_ID = 10,
                Product_Name = "DesktopLED 21",
                Product_Production_Start = new DateTime(2012, 6, 1, 12, 0, 0),
                Product_Available = true,
                Product_Current_Inventory = 0,
                Product_Cost = 75.00,
                Product_Sale_Price = 125.00,
                Product_Retail_Price = 175.00,
                Product_Consumer_Rating = 4.5,
                Product_Category = "Monitors"
            },
            new Product {
                Product_ID = 11,
                Product_Name = "DesktopLED 19",
                Product_Production_Start = new DateTime(2012, 5, 30, 17, 30, 0),
                Product_Available = true,
                Product_Current_Inventory = 425,
                Product_Cost = 70.00,
                Product_Sale_Price = 115.00,
                Product_Retail_Price = 165.00,
                Product_Consumer_Rating = 5,
                Product_Category = "Monitors"
            },
            new Product {
                Product_ID = 12,
                Product_Name = "DesktopLCD 21",
                Product_Production_Start = new DateTime(2010, 3, 31, 17, 0, 0),
                Product_Available = true,
                Product_Current_Inventory = 210,
                Product_Cost = 75.00,
                Product_Sale_Price = 120.00,
                Product_Retail_Price = 170.00,
                Product_Consumer_Rating = 3,
                Product_Category = "Monitors"
            },
            new Product {
                Product_ID = 13,
                Product_Name = "DesktopLCD 19",
                Product_Production_Start = new DateTime(2010, 3, 31, 9, 0, 0),
                Product_Available = true,
                Product_Current_Inventory = 150,
                Product_Cost = 68.00,
                Product_Sale_Price = 110.00,
                Product_Retail_Price = 160.00,
                Product_Consumer_Rating = 5,
                Product_Category = "Monitors"
            },
            new Product {
                Product_ID = 14,
                Product_Name = "Projector Plus",
                Product_Production_Start = new DateTime(2010, 7, 30, 4, 15, 0),
                Product_Available = true,
                Product_Current_Inventory = 0,
                Product_Cost = 225.00,
                Product_Sale_Price = 400.00,
                Product_Retail_Price = 550.00,
                Product_Consumer_Rating = 3.5,
                Product_Category = "Projectors"
            },
            new Product {
                Product_ID = 15,
                Product_Name = "Projector PlusHD",
                Product_Production_Start = new DateTime(2012, 12, 1, 17, 30, 0),
                Product_Available = true,
                Product_Current_Inventory = 110,
                Product_Cost = 425.00,
                Product_Sale_Price = 600.00,
                Product_Retail_Price = 750.00,
                Product_Consumer_Rating = 3,
                Product_Category = "Projectors"
            },
            new Product {
                Product_ID = 16,
                Product_Name = "Projector PlusHT",
                Product_Production_Start = new DateTime(2013, 1, 15, 0, 0, 0),
                Product_Available = true,
                Product_Current_Inventory = 0,
                Product_Cost = 725.00,
                Product_Sale_Price = 900.00,
                Product_Retail_Price = 1050.00,
                Product_Consumer_Rating = 4,
                Product_Category = "Projectors"
            },
            new Product {
                Product_ID = 17,
                Product_Name = "ExcelRemote IR",
                Product_Production_Start = new DateTime(2012, 8, 1, 0, 0, 0),
                Product_Available = true,
                Product_Current_Inventory = 650,
                Product_Cost = 55.00,
                Product_Sale_Price = 105.00,
                Product_Retail_Price = 150.00,
                Product_Consumer_Rating = 5,
                Product_Category = "Automation"
            },
            new Product {
                Product_ID = 18,
                Product_Name = "ExcelRemote Bluetooth",
                Product_Production_Start = new DateTime(2012, 9, 1, 12, 0, 0),
                Product_Available = true,
                Product_Current_Inventory = 310,
                Product_Cost = 85.00,
                Product_Sale_Price = 135.00,
                Product_Retail_Price = 180.00,
                Product_Consumer_Rating = 4.5,
                Product_Category = "Automation"
            },
            new Product {
                Product_ID = 19,
                Product_Name = "ExcelRemote IP",
                Product_Production_Start = new DateTime(2012, 10, 1, 1, 30, 0),
                Product_Available = true,
                Product_Current_Inventory = 0,
                Product_Cost = 105.00,
                Product_Sale_Price = 155.00,
                Product_Retail_Price = 200.00,
                Product_Consumer_Rating = 3,
                Product_Category = "Automation"
            }
        ];
    }
}
