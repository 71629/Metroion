using Metroion.Events;
using Metroion.Singleton;

namespace Metroion.StationBuilder
{
    public class StationBuilder : Singleton<StationBuilder>
    {
        // Event list
        public readonly MetroionEvent OnInitialize = new MetroionEvent();

        public readonly MetroionEvent OnStationInitialize = new MetroionEvent();
        
        public readonly MetroionEvent OnCreateSegment = new MetroionEvent();
        public readonly MetroionEvent OnDestroySegment = new MetroionEvent();
        
        public readonly MetroionEvent OnBuilderRefresh = new MetroionEvent();
        
        public readonly MetroionEvent OnDestroy = new MetroionEvent();
    }
}