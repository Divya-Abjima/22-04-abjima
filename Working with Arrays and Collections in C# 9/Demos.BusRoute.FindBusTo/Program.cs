namespace Demos.BusRoute
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRoute[] routes = BusRouteRepository.InitializeRoutes();
            Console.WriteLine("Where do you want to go?");
            string location = Console.ReadLine();

            BusRoute route = FindBusTo(routes, location);

            if (route != null )
                Console.WriteLine($"You can use route {route}");
            else
                Console.WriteLine($"No routes go to {location}");
        }

        public static BusRoute FindBusTo(BusRoute[] routes, string location)
        {
            foreach (BusRoute route in routes)
            {
                if (route.Origin == location || route.Destination == location)
                    return route;
            }
            return null;
        }
    }
}