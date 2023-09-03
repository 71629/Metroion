using Metroion.Events;
using Metroion.Singleton;

namespace Metroion.StationManager
{
    public class StationManager : Singleton<StationManager>
    {
        public readonly MetroionEvent OnStationOpen = new MetroionEvent();
        public readonly MetroionEvent OnStationClose = new MetroionEvent();
    }
}