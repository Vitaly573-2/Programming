public enum OrderStatus //статус
{
    //новый заказ
    New,
    
    //обрабатывается
    Processiing,

    //собирается на складе
    Assembly,

    //отправлен
    Sent,

    //доставлен
    Delivered,

    //возврат
    Returned,

    //отменен
    Abandoned
}