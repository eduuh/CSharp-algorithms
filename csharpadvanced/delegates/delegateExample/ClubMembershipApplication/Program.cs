// See https://aka.ms/new-console-template for more information
using ClubMemberShipApplication;
using ClubMemberShipApplication.FieldValidors;
using ClubMemberShipApplication.Views;

IView mainView = Factory.GetMainViewObject();
mainView.RunView();

Console.ReadKey();
