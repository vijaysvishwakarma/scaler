package designPatterns.observer;

public class Client {
    public static void main(String[] args) {
        Amazon a = Amazon.getInstance();
        SCMNotifier scmNotifier = new SCMNotifier();
        CustomerNotifier customerNotifier = new CustomerNotifier();
        SellerNotifier sellerNotifier = new SellerNotifier();
        AnalyticsService analyticsService = new AnalyticsService();

        a.orderPlaceEvent();
    }
}
