using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class ArrayCollection : Collection
    {
        private int SIZE;
        private int cap;
        private object[] data;


        public ArrayCollection(int cap)
        {
            data = new object[cap];
            this.cap = cap;
        }
        public void add(object e)
        {
            ensureCapacity();
            data[SIZE++] = e;
        }

        public bool contains(object e)
        {
            return indexOf(e) != -1; //ถ้า Object e อยู่ในArray จะคืนค่าที่ไม่ใช่ -1
        }
        private int indexOf(object e) //ไม่ใช่ Service แต่เป็น private Method
        {
            for (int i = 0; i < SIZE; i++)
                if (data[i].Equals(e))
                    return i; //คืนค่าเป็น index
            return -1; //return ตัวเลขอะไรก็ได้ที่ไม่ใช่ index ของ Array
        }

        public void remove(object e)
        {
            int i = indexOf(e);
            if (i < 0)
                return;
            data[i] = data[--SIZE];
            data[SIZE] = null;
        }

        public bool isEmpty()
        {
            return SIZE == 0;
        }



        public int size() //read only method
        {
            return SIZE;
        }
        private void ensureCapacity()
        {
            if (SIZE + 1 > data.Length)
            {
                object[] tempdata = new object[2 * SIZE];
                for (int i = 0; i < SIZE; i++)
                    tempdata[i] = data[i]; //เทข้อมูลจากถังใบเก่าไปใบใหม่
                data = tempdata; //โยนข้อมูลจากถังเก่าทิ้งไป
            }
        }
    }
}
