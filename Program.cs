using System;
using System.Numerics;
using System.Xml.Linq;

namespace FINAL_7._7{
    internal class Program{
        static void Main(string phone){
            CheckPhone checkPhone = new CheckPhone();
            checkPhone.CheckP(phone, out int correctPhone);
            /* ... */
        }

        class AllPersons{
            public string Name;
            public string Surname;
        }

       
        abstract class Delivery{ // абстрактный класс
            public string Address;

            protected virtual void ShippingType(){ // protected модификатор метода
                /* ... */ // реализация метода
            }
        }

        class HomeDelivery : Delivery{ // наследование
            protected override void ShippingType(){ // protected модификатор метода, c новой реализацией
                /* ... */ // реализация метода
            }
        }

        class PickPointDelivery : Delivery{ // наследование
            protected override void ShippingType(){ // protected модификатор метода, c новой реализацией
                /* ... */ // реализация метода
            }
        }

        class ShopDelivery : Delivery{ // наследование
            protected override void ShippingType(){ // protected модификатор метода, c новой реализацией
                /* ... */ // реализация метода
            }
        }

        class Order<TDelivery, TStruct> where TDelivery : Delivery{ // обобщение
            public TDelivery Delivery;

            public int Number;

            public string Description;

            public void DisplayAddress(){
                Console.WriteLine(Delivery.Address);
            }
        }

        class Customer : AllPersons{
            private int Age;
            private string Phone;
            private string Adress;
            /* ..
             * 
             * 
             * 
             * . */


            public int VerificationAge{get{return Age;} set{if (value <= 20){ Console.WriteLine("Не подходящий возраст для покупки алкоголя");} else{Age = value;}
                }
            }
            public Customer(string _Name, string _Numberphone, string _Adress, string _Surname, int _Age)
            {
                Name = _Name;
                Phone = _Numberphone;
                Adress = _Adress;
                Surname = _Surname;
                Age = _Age;
            }
        }
        class Deliveryman : AllPersons{ // копозиция
            private HomeDelivery _homeDelivery;

            private PickPointDelivery _pickPointDelivery;

            private ShopDelivery _shopDelivery;

            public Deliveryman(){
                _homeDelivery = new HomeDelivery();

                _pickPointDelivery = new PickPointDelivery();

                _shopDelivery = new ShopDelivery();
            }
        }
    }
}