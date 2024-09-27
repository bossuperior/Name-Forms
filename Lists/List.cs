using Collections;

namespace Lists
{
    public interface List : Collection
    {
        void add(int index, object e);
        void remove(int index);
        object get(int index); //return เป็น Object
        void set(int index, object e);  
        int index(object e);
    }
}
