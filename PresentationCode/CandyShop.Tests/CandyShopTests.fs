module ``Candy shop example``

open System
open Xunit
open FsUnit.Xunit
open CandyShop.Interfaces
open CandyShop.Model
open Foq

[<Fact>]
let ``BuyTastiestCandy should buy top selling candy from shop`` () =
   let lollipop = { new ICandy }

   let mutable boughtCandy = false

   let shop = { new ICandyShop with
                  member x.GetTopSellingCandy() =
                     lollipop 
                  member x.BuyCandy candy =
                     boughtCandy <- true;
                     ()}
   
   let developer = new SweetTooth()
   developer.BuyTastiestCandy(shop);

   boughtCandy |> should be True
   

[<Fact>]
let ``BuyTastiestCandy should buy top selling candy from shop with FOQ`` () =
   let lollipop = { new ICandy }

   let shop = Mock<ICandyShop>()
               .Setup(fun x -> <@ x.GetTopSellingCandy() @>).Returns(lollipop)
               .Create()

   let developer = new SweetTooth()
   developer.BuyTastiestCandy(shop);

   Mock.Verify(<@ shop.BuyCandy(lollipop) @>)
   
   //A.CallTo(() => shop.BuyCandy(lollipop)).MustHaveHappened();
