namespace FINAL_7._7{
    internal class Program{
        static void Main(){
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
            /* ..
             * 
             * 
             * 
             * . */


            public int VerificationAge{get{return Age;} set{if (value <= 20){ Console.WriteLine("Не подходящий возраст для покупки алкоголя");} else{Age = value;}
                }
            }

        }
    }
}