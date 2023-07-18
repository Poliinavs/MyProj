namespace Observable
{
    public interface IObserver //реализуется всеми наблюдателями
    {
        public void update(float temp, float humidity);//инфа, которая передается при изменении состояния
    }
}