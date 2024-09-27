using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class LinkedCollection : Collection
    {
        private class LinkedNode
        {
            public object e;
            public LinkedNode next;
            //ไม่ต้องสร้าง cap เพราะ pre allocation ใหม่

            public LinkedNode(object e, LinkedNode next) //สร้าง constructor เพื่อรับค่า object กับ pointer
            {
                this.e = e;
                this.next = next;

            }
        }
        private LinkedNode first; //Use Dafault Constructor --> first = null
        private int SIZE; //SIZE = 0
        public void add(object e)
        {
            first = new LinkedNode(e, first); //สร้าง LinkedNode ต่อจาก First 
            SIZE++;
        }

        public bool contains(object e)
        {
            LinkedNode node = first;
            while (node != null) //ถ้าหลัง first ไม่เท่ากับ null
            {
                if (node.e.Equals(e))
                    return true;
                node = node.next;
            }
            return false;
        }

        public bool isEmpty()
        {
            return first == null;
        }

        public void remove(object e)
        {
            if (SIZE == 0) return;   //หรือใช้ first == null
            //ลบ node ที่ต่อจาก first
            if (first.e.Equals(e))
            {
                first = first.next;
                SIZE--; return;
            }
            //ลบ Node อื่นๆ 
            LinkedNode node = first; //Default Constructor --> first = null
            while (node != null)
            { //เข้า loop เมื่อหลัง first ไม่เป็น null (มี Pointer ชี้ออกมา)
                if (node.next.e.Equals(e))
                { //ถ้าข้าม node ที่ต่อจาก first ไปแล้วเจอ node ที่มี object ตรงกับที่กำหนด
                    node.next = node.next.next; //เปลี่ยน pointer ของ node ที่ต่อจาก first ให้ชี้ไปที่ node ถัดไป ส่วน node ตัวเดิมจะกลายเป็น Garbage
                    SIZE--; return; // Update the size
                }
                node = node.next; //ไปกล่องถัดไป
            }
        }

        public int size()
        {
            return SIZE;
        }
    }
}
