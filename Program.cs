namespace FINAL_7._7{
    internal class Program{
        static void Main(){
            Console.WriteLine("77");
        }
        abstract class Delivery{
            public string Address;

            protected virtual void DisplayStatus(){
                Console.WriteLine("Доставка");
            }
        }

        class HomeDelivery : Delivery{
            protected override void DisplayStatus(){
                Console.WriteLine("Доставка на дом");
            }
        }

        class PickPointDelivery : Delivery{
            protected override void DisplayStatus(){
                Console.WriteLine("Доставка в пункт выдачи");
            }
        }

        class ShopDelivery : Delivery{
            protected override void DisplayStatus(){
                Console.WriteLine("Доставка в магазин");
            }
        }

        class Order<TDelivery, TStruct> where TDelivery : Delivery{
            public TDelivery Delivery;

            public int Number;

            public string Description;

            public void DisplayAddress(){
                Console.WriteLine(Delivery.Address);
            }
        }

        
    }
}