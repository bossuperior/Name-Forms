using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class ArrayList : List
    {
        //Private เพื่อไม่ให้ User มาแก้ไขได้
        private object[] data;
        //จอง Memory แล้ว Constructor จะถูกเรียกขึ้นมา
        private int cap ,SIZE; //ค่า int เริ่มต้นคือ 0
        public ArrayList(int cap) { //Custom Constructor
            this.cap = cap;
            data = new object[cap]; //ไม่ใส่ this.data เพราะไม่มีชื่อซ้ำ
        } 
        //add มี 2 signature
        public void add(object e) { //เติมข้อมูลต่อท้าย
            add(SIZE, e); //ดึง signature add อีกตัวนึงมาใช้ โดยการ add ต่อท้ายสุดเสมอ
        }
        public void add(int index, object e) { //แทรกข้อมูล
            ensureCapacity();
            for (int i = SIZE; i > index; i--) 
                data[i] = data[i-1];
            data[index] = e; //เปลี่ยน pointer ไปชี้ที่ element ตัวใหม่
            SIZE++; //เพิ่มขนาด SIZE
        }
        public void remove(object e) { //remove ตัวใกล้ index 0 มากสุด
            int i = indexOf(e);
            if (i >= 0) //ดัก Error ถ้า index = -1
                remove(i);
        }
        public void remove(int index) {
            /*for(int i = index+1 ; i<SIZE ; i++)
                data[i-1] = data[i]*/
            if (index >= SIZE) return;
            for (int i = index; i < SIZE-1; i++)
                data[i] = data[i + 1];
                data[--SIZE] = null;
        }
        public object get(int index) {
            return data[index];
        }
        public void set(int index, object e) {
            /*if (index < 0 || index > SIZE) return;  เช็คว่า index อยู่ใน Array หรือเปล่า*/
            data[index] = e;// Set ค่า
        }
        public int indexOf(object e) {
            for (int i = 0; i < SIZE; i++)
                if (data[i] != null && data[i].Equals(e)) return i; //คืนค่าเป็น index
            return -1; //return ตัวเลขอะไรก็ได้ที่ไม่ใช่ index ของ Array
        }
        public bool contains(object e) {
            return indexOf(e) != -1; //ถ้า Object e อยู่ในArray จะคืนค่าที่ไม่ใช่ -1
        }
        public int size() { //Read-only Method
            return SIZE;
        }
        public bool isEmpty() {
            return SIZE == 0;
        }

        public int index(object e)
        {
            throw new NotImplementedException();
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
