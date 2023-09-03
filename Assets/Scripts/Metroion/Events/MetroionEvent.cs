namespace Metroion.Events
{
    public class MetroionEvent
    {
        public delegate void StationBuilderEventHandler(params object[] param);
        public event StationBuilderEventHandler OnStationBuilderEvent;

        public void AddListener(StationBuilderEventHandler func) => OnStationBuilderEvent += func;
        public void RemoveListener(StationBuilderEventHandler func) => OnStationBuilderEvent -= func;
        public void Trigger(params object[] param) => OnStationBuilderEvent?.Invoke(param);
    }
}