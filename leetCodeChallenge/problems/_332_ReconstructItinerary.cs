using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _332_ReconstructItinerary
    {
        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            Dictionary<string, Airport> airports = new Dictionary<string, Airport>();
            foreach(var ticket in tickets)
            {
                string from = ticket[0];
                string to = ticket[1];
                if (airports.TryGetValue(from, out Airport airport))
                {
                    airport.putTicket(to);
                }
                else
                { 
                    airport = new Airport();
                    airports.Add(from, airport);
                    airport.putTicket(to);
                }

                if (!airports.TryGetValue(to, out Airport toAirport))
                {
                    toAirport = new Airport();
                    airports.Add(to, toAirport);
                }
            }

            foreach(var airport in airports.Values) 
            {
                airport.sort();
            }

            List<string> fliedSteps = new List<string>();
            fliedSteps.Add("JFK");

            _ = fly(airports, "JFK", fliedSteps, tickets.Count);

            return fliedSteps;
        }

        public static bool fly(Dictionary<string, Airport> airports, string takeoffAirPort, List<string> fliedSteps, int shallFliyStepCount)
        { 
            Airport currentAirport = airports[takeoffAirPort];
            foreach (string des in currentAirport.destinations)
            {
                if (currentAirport.tickets[des] > 0)
                {
                    currentAirport.tickets[des] -= 1;
                    fliedSteps.Add(des);
                    bool result = fly(airports, des, fliedSteps, shallFliyStepCount);
                    if(result)
                    {
                        return true;
                    }

                    // not succeeded
                    currentAirport.tickets[des] += 1;
                    fliedSteps.RemoveAt(fliedSteps.Count - 1);
                }
            }

            return (fliedSteps.Count == shallFliyStepCount + 1);
        }
    }

    public class Airport
    { 
        public List<string> destinations = new List<string>();
        public Dictionary<string,int> tickets = new Dictionary<string,int>();

        public void putTicket(string des)
        {
            if (tickets.TryGetValue(des, out int ticketCount))
            {
                tickets[des] = ticketCount + 1;
            }
            else
            { 
                destinations.Add(des);
                tickets[des] = 1;
            }
        }

        public void sort()
        {
            destinations.Sort();
        }
    }
}
