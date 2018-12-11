using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityClasses;

namespace UniversityClasses
{
    [System.Serializable]
    class Manager
    {
        public string firstName
        {
            get; set;
        }
        public string lastName
        {
            get; set;
        }
        public string password
        {
            get; set;
        }
        public ulong id
        {
            get; set;
        }
        //-----------------------------------------
        //Constructors
        public Manager(string firstName, string lastName, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            Node<Manager> lastMngRow = Universal.instance.lastMng;
            Node<Manager> lastMng = lastMngRow;
            while (lastMng.next != null)
            {
                lastMng = lastMng.next;
            }
            id = lastMng.info.id + 1;
        }
        public Manager()
        {
            Console.WriteLine("hello");
            firstName = "admin";
            lastName = "admin";
            password = "1234";
            id = 96000000000;
        }
        //-----------------------------------------
        //functions
        public int EditPassword(string currentPassWord, string newPassword, string newPasswordAgain)
        {
            if (currentPassWord != this.password)
            {
                // Have To Show Error for current password
                return 0;
            }
            else
            {
                if (newPassword != newPasswordAgain)
                {
                    // Have To Show Error for confirmation password
                    return 1;
                }
                else
                {
                    this.password = newPassword;
                    return 2;
                }
            }

            //End of Method
        }
        public bool SignUpStudent(string firstName, string lastName, string major)
        {
            if (isValidName(firstName) && isValidName(lastName))
            {

                Student newStudent = new Student(firstName.Trim(), lastName.Trim(), major);
                //Now Here we have to check the Nodes
                if (Universal.instance.firstStd == null)
                {
                    RowNode<Student> newRowNode = new RowNode<Student>();
                    newRowNode.info = newStudent;
                    Universal.instance.firstStd = Universal.instance.lastStd = newRowNode;
                }
                else
                {
                    Node<Student> lastStdRow = Universal.instance.lastStd;
                    Node<Student> lastStd = lastStdRow;
                    while (lastStd.next != null)
                    {
                        lastStd = lastStd.next;
                    }
                    if (lastStd.info.id % 10 == 9)
                    {
                        RowNode<Student> newRowNode = new RowNode<Student>();
                        newRowNode.info = newStudent;
                        Universal.instance.lastStd.nextRow = newRowNode;
                        Universal.instance.lastStd = newRowNode;
                    }
                    else
                    {
                        Node<Student> newNode = new Node<Student>();
                        newNode.info = newStudent;
                        lastStd.next = newNode;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
            //End of Method
        }
        public bool SignUpMaster(string firstName, string lastName, List<Course> lessons)
        {
            if (isValidName(firstName) && isValidName(lastName))
            {
                Master newMaster = new Master(firstName, lastName, lessons);
                //Now Here we have to check the Nodes
                if (Universal.instance.firstMst == null)
                {
                    RowNode<Master> newRowNode = new RowNode<Master>();
                    newRowNode.info = newMaster;
                    Universal.instance.firstMst = Universal.instance.lastMst = newRowNode;
                }
                else
                {
                    Node<Master> lastMstRow = Universal.instance.lastMst;
                    Node<Master> lastMst = lastMstRow;
                    while (lastMst.next != null)
                    {
                        lastMst = lastMst.next;
                    }
                    if (lastMst.info.id % 10 == 9)
                    {
                        RowNode<Master> newRowNode = new RowNode<Master>();
                        newRowNode.info = newMaster;
                        Universal.instance.lastMst.nextRow = newRowNode;
                        Universal.instance.lastMst = newRowNode;
                    }
                    else
                    {
                        Node<Master> newNode = new Node<Master>();
                        newNode.info = newMaster;
                        lastMst.next = newNode;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
            //End of Method
        }
        public bool SignUpManager(string firstName, string lastName, string password)
        {
            if (isValidName(firstName) && isValidName(lastName))
            {
                Manager newManager = new Manager(firstName.Trim(), lastName.Trim(), password);
                //Now Here we have to check the Nodes
                Node<Manager> lastMngRow = Universal.instance.lastMng;
                Node<Manager> lastMng = lastMngRow;
                while (lastMng.next != null)
                {
                    lastMng = lastMng.next;
                }
                if (lastMng.info.id % 10 == 9)
                {
                    RowNode<Manager> newRowNode = new RowNode<Manager>();
                    newRowNode.info = newManager;
                    Universal.instance.lastMng.nextRow = newRowNode;
                    Universal.instance.lastMng = newRowNode;
                }
                else
                {
                    Node<Manager> newNode = new Node<Manager>();
                    newNode.info = newManager;
                    lastMng.next = newNode;
                }
                return true;

            }
            else
            {
                return false;
            }
            //End of Method
        }
        public bool AddCourse(String code, String name, String mstId, String time, String examTime, int val)
        {
            if (isValidName(name) && isNumber(code) && isNumber(mstId) && (SearchMaster(mstId) != null))
            {
                Course newCourse = new Course(name.Trim(), Convert.ToInt32(code.Trim()), val, time, examTime, SearchMaster(mstId).info);
                Node<Course> newNode = new Node<Course>();
                //Now Here we have to check the Nodes
                if (Universal.instance.firstCrs == null)
                {
                    newNode.info = newCourse;
                    Universal.instance.firstCrs = Universal.instance.lastCrs = newNode;
                }
                else
                {
                    newNode.info = newCourse;
                    Universal.instance.lastCrs.next = newNode;
                    Universal.instance.lastCrs = newNode;
                }
                return true;
            }
            else
            {
                return false;
            }
            //End of Method
        }
        public static RowNode<Student> SearchPrevStudent(string id)
        {
            /**
            Returning the previous Student of that id
            **/
            if (isNumber(id))
            {
                if (Universal.instance.firstStd.info.id > Convert.ToUInt64(id) || Universal.instance.firstStd.info.id + 9 < Convert.ToUInt64(id))
                {
                    //Showing Error
                    return null;
                }
                else
                {
                    ulong subId = Convert.ToUInt64(id.Substring(0, 10));
                    RowNode<Student> pstd = Universal.instance.firstStd;
                    if (pstd != null)
                    {
                        RowNode<Student> std = pstd;

                        while (subId > pstd.info.id / 10)
                        {
                            if (Convert.ToUInt64(id) == std.nextRow.info.id)
                            {
                                return std;
                            }
                            pstd = pstd.nextRow;
                        }

                        if (subId < pstd.info.id / 10)
                        {
                            //Showing Error
                            return null;
                        }
                        else
                        {
                            //Horizontal navigation
                            while (std.next != null)
                            {
                                if (Convert.ToUInt64(id) == std.next.info.id)
                                {
                                    return std;
                                }
                                std = std.next as RowNode<Student>;
                            }
                            //Showing Error
                            return null;
                        }
                    }
                    else
                    {
                        //Showing Error
                        return null;
                    }
                }
            }
            else
            {
                return null;
            }
        }
        public static RowNode<Master> SearchPrevMaster(string id)
        {
            /**
            Returning the previous Student of that id
            **/
            if (isNumber(id))
            {
                if (Universal.instance.firstMst.info.id > Convert.ToUInt64(id) || Universal.instance.firstMst.info.id + 9 < Convert.ToUInt64(id))
                {
                    //Showing Error
                    return null;
                }
                else
                {
                    ulong subId = Convert.ToUInt64(id.Substring(0, 10));
                    RowNode<Master> pstd = Universal.instance.firstMst;
                    if (pstd != null)
                    {
                        RowNode<Master> mst = pstd;

                        while (subId > pstd.info.id / 10)
                        {
                            if (Convert.ToUInt64(id) == mst.nextRow.info.id)
                            {
                                return mst;
                            }
                            pstd = pstd.nextRow;
                        }

                        if (subId < pstd.info.id / 10)
                        {
                            //Showing Error
                            return null;
                        }
                        else
                        {
                            //Horizontal navigation
                            while (mst.next != null)
                            {
                                if (Convert.ToUInt64(id) == mst.next.info.id)
                                {
                                    return mst;
                                }
                                mst = mst.next as RowNode<Master>;
                            }
                            //Showing Error
                            return null;
                        }
                    }
                    else
                    {
                        //Showing Error
                        return null;
                    }
                }
            }
            else
            {
                return null;
            }
        }
        public static RowNode<Manager> SearchPrevManager(string id)
        {
            /**
            Returning the previous Student of that id
            **/
            if (isNumber(id))
            {
                if (Universal.instance.firstMng.info.id > Convert.ToUInt64(id) || Universal.instance.firstMng.info.id + 9 < Convert.ToUInt64(id))
                {
                    //Showing Error
                    return null;
                }
                else
                {
                    ulong subId = Convert.ToUInt64(id.Substring(0, 10));
                    RowNode<Manager> pstd = Universal.instance.firstMng;
                    if (pstd != null)
                    {
                        RowNode<Manager> mng = pstd;

                        while (subId > pstd.info.id / 10)
                        {
                            if (Convert.ToUInt64(id) == mng.nextRow.info.id)
                            {
                                return mng;
                            }
                            pstd = pstd.nextRow;
                        }

                        if (subId < pstd.info.id / 10)
                        {
                            //Showing Error
                            return null;
                        }
                        else
                        {
                            //Horizontal navigation
                            while (mng.next != null)
                            {
                                if (Convert.ToUInt64(id) == mng.next.info.id)
                                {
                                    return mng;
                                }
                                mng = mng.next as RowNode<Manager>;
                            }
                            //Showing Error
                            return null;
                        }
                    }
                    else
                    {
                        //Showing Error
                        return null;
                    }
                }
            }
            else
            {
                return null;
            }
        }
        public static Node<Student> SearchStudent(string id)
        {
            if (Universal.instance != null && Universal.instance.firstStd != null && isNumber(id) && id.Length == 11)
            {
                if (Universal.instance.firstStd.info.id > Convert.ToUInt64(id) || Universal.instance.firstStd.info.id + 9 < Convert.ToUInt64(id))
                {
                    //Showing Error
                    return null;
                }
                else {
                    ulong subId = Convert.ToUInt64((id.Substring(0, 10)));
                    RowNode<Student> pstd = Universal.instance.firstStd;
                    if (pstd != null)
                    {
                        while (subId > pstd.info.id / 10)
                        {
                            pstd = pstd.nextRow;
                        }
                        if (subId < pstd.info.id / 10)
                        {
                            //Showing Error
                            return null;
                        }
                        else
                        {
                            Node<Student> std = pstd;
                            while (std != null)
                            {
                                if (std.info.id == Convert.ToUInt64((id)))
                                {
                                    return std;
                                }
                                std = std.next;
                            }
                            return null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            else
            {
                return null;
            }
            //End of Method
        }
        public static Node<Master> SearchMaster(string id)
        {
            if (isNumber(id))
            {
                if (Universal.instance.firstMst.info.id > Convert.ToUInt64(id) || Universal.instance.firstMst.info.id + 9 < Convert.ToUInt64(id))
                {
                    //Showing Error
                    return null;
                }
                else {
                    ulong subId = Convert.ToUInt64(id.Substring(0, 10));
                    RowNode<Master> pstd = Universal.instance.firstMst;
                    if (pstd != null)
                    {
                        while (subId > pstd.info.id / 10)
                        {
                            pstd = pstd.nextRow;
                        }
                        if (subId < pstd.info.id / 10)
                        {
                            //Showing Error
                            return null;
                        }
                        else
                        {
                            Node<Master> std = pstd;
                            while (std != null)
                            {
                                if (std.info.id == Convert.ToUInt64(id))
                                {
                                    return std;
                                }
                                std = std.next;
                            }
                            return null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            else
            {
                return null;
            }
            //End of Method
        }
        public static Node<Manager> SearchManager(string id)
        {
            if (id.Length == 11 && isNumber(id))
            {
                if (Universal.instance.firstMng.info.id > Convert.ToUInt64(id) || Universal.instance.lastMng.info.id + 9 < Convert.ToUInt64(id))
                {
                    //Showing Error
                    return null;
                }
                else {
                    ulong subId = Convert.ToUInt64(id.Substring(0, 10));
                    RowNode<Manager> pstd = Universal.instance.firstMng;
                    if (pstd != null)
                    {
                        while (subId > pstd.info.id / 10)
                        {
                            pstd = pstd.nextRow;
                        }
                        if (subId < pstd.info.id / 10)
                        {
                            //Showing Error
                            return null;
                        }
                        else
                        {
                            Node<Manager> std = pstd;
                            while (std != null)
                            {
                                if (std.info.id == Convert.ToUInt64(id))
                                {
                                    return std;
                                }
                                std = std.next;
                            }
                            return null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            else
            {
                return null;
            }
            //End of Method
        }
        public bool RemoveStudentFully(string id)
        {
            if (Universal.instance.firstStd != null && isNumber(id))// Checking whether we have student or not
            {

                Node<Student> exactStd = Universal.instance.lastStd;
                while(exactStd.next != null)
                {
                    exactStd = exactStd.next;
                }

                if (Universal.instance.firstStd != exactStd)//Checking if we have more than one student 
                {

                    if (Convert.ToUInt64(id) == Universal.instance.firstStd.info.id)  //Means that we wanna delete the first Student
                    {
                        RowNode<Student> newfirstRowNode = new RowNode<Student>();
                        newfirstRowNode.info = Universal.instance.firstStd.next.info;
                        newfirstRowNode.next = Universal.instance.firstStd.next.next;
                        newfirstRowNode.nextRow = Universal.instance.firstStd.nextRow;
                        Universal.instance.firstStd = newfirstRowNode;
                        return true;
                    }
                    else if (Convert.ToUInt64(id) == Universal.instance.lastStd.info.id)//Means that we wanna delete the last Student
                    {
                        RowNode<Student> newlasttRowNode = new RowNode<Student>();
                        if (Universal.instance.lastStd.next != null) // Checking if we have convertable node to RowNode
                        {
                            newlasttRowNode.info = Universal.instance.lastStd.next.info;
                            newlasttRowNode.next = Universal.instance.lastStd.next.next;
                            Universal.instance.lastStd = newlasttRowNode;
                            return true;
                        }
                        else // Here we don't have convertable node to RowNode
                        {
                            RowNode<Student> lastStd = Universal.instance.lastStd;
                            while (lastStd.nextRow != null)
                            {
                                lastStd = lastStd.nextRow;
                            }
                            Universal.instance.lastStd = lastStd;
                            return true;
                        }
                    }
                    else // Here we want to delete the students in which there are at the Middle Nodes
                    {
                        RowNode<Student> prev = new RowNode<Student>();
                        prev = SearchPrevStudent(id);
                        if (prev != null) //if the student exists
                        {
                            if (prev.nextRow != null)//Prev is RowNode
                            {

                                if (prev.nextRow.info.id == Convert.ToUInt64(id))//Deleting node is nextRowNode
                                {
                                    if (prev.nextRow.next != null)//if the deleting RowNode has nextNode
                                    {
                                        prev.nextRow.info = prev.nextRow.next.info;
                                        prev.nextRow.next = prev.nextRow.next.next;
                                    }
                                    else //deleting RowNode doesn't have nextNode
                                    {
                                        prev.nextRow = prev.nextRow.nextRow;
                                    }
                                }
                                else // Deleting node is nextNode
                                {
                                    prev.next = prev.next.next;
                                }
                            }
                            else //Prev is not RowNode = Usual Node 
                            {
                                prev.next = prev.next.next;
                            }
                        }
                        else // Student doesn't exist
                        {
                            return false;
                        }
                        return false;
                    }

                }
                else // We have just one student 
                {
                    Universal.instance.firstStd = null;
                    Universal.instance.lastStd = null;
                    return true;
                }
            }
            else
            {
                //Showing Errore that the insterted id is wrong
                return false;
            }
            //End of Method
        }
        public bool RemoveMasterFully(string id)
        {
            if (Universal.instance.firstMst != null && isNumber(id))// Checking whether we have student or not
            {
                if (Universal.instance.firstMst != Universal.instance.lastMst)//Checking if we have more than one student 
                {

                    if (Convert.ToUInt64(id) == Universal.instance.firstMst.info.id)  //Means that we wanna delete the first Student
                    {
                        RowNode<Master> newfirstRowNode = new RowNode<Master>();
                        newfirstRowNode.info = Universal.instance.firstMst.next.info;
                        newfirstRowNode.next = Universal.instance.firstMst.next.next;
                        newfirstRowNode.nextRow = Universal.instance.firstMst.nextRow;
                        Universal.instance.firstMst = newfirstRowNode;
                        return true;
                    }
                    else if (Convert.ToUInt64(id) == Universal.instance.lastMst.info.id)//Means that we wanna delete the last Student
                    {
                        RowNode<Master> newlasttRowNode = new RowNode<Master>();
                        if (Universal.instance.lastMst.next != null) // Checking if we have convertable node to RowNode
                        {
                            newlasttRowNode.info = Universal.instance.lastMst.next.info;
                            newlasttRowNode.next = Universal.instance.lastMst.next.next;
                            Universal.instance.lastMst = newlasttRowNode;
                            return true;
                        }
                        else // Here we don't have convertable node to RowNode
                        {
                            RowNode<Master> lastMst = Universal.instance.lastMst;
                            while (lastMst.nextRow != null)
                            {
                                lastMst = lastMst.nextRow;
                            }
                            Universal.instance.lastMst = lastMst;
                            return true;
                        }
                    }
                    else // Here we want to delete the students in which there are at the Middle Nodes
                    {
                        RowNode<Master> prev = new RowNode<Master>();
                        prev = SearchPrevMaster(id);
                        if (prev != null) //if the student exists
                        {
                            if (prev.nextRow != null)//Prev is RowNode
                            {

                                if (prev.nextRow.info.id == Convert.ToUInt64(id))//Deleting node is nextRowNode
                                {
                                    if (prev.nextRow.next != null)//if the deleting RowNode has nextNode
                                    {
                                        prev.nextRow.info = prev.nextRow.next.info;
                                        prev.nextRow.next = prev.nextRow.next.next;
                                    }
                                    else //deleting RowNode doesn't have nextNode
                                    {
                                        prev.nextRow = prev.nextRow.nextRow;
                                    }
                                }
                                else // Deleting node is nextNode
                                {
                                    prev.next = prev.next.next;
                                }
                            }
                            else //Prev is not RowNode = Usual Node 
                            {
                                prev.next = prev.next.next;
                            }
                        }
                        else // Student doesn't exist
                        {
                            return false;
                        }
                        return false;
                    }

                }
                else // We have just one student 
                {
                    Universal.instance.firstMst = null;
                    Universal.instance.lastMst = null;
                    return true;
                }
            }
            else
            {
                //Showing Errore that the insterted id is wrong
                return false;
            }
            //End of Method
        }
        public bool RemoveManagerFully(string id)
        {
            if (Universal.instance.firstMng != null && isNumber(id))// Checking whether we have student or not
            {
                if (Universal.instance.firstMng != Universal.instance.lastMng)//Checking if we have more than one student 
                {

                    if (Convert.ToUInt64(id) == Universal.instance.firstMng.info.id)  //Means that we wanna delete the first Student
                    {
                        RowNode<Manager> newfirstRowNode = new RowNode<Manager>();
                        newfirstRowNode.info = Universal.instance.firstMng.next.info;
                        newfirstRowNode.next = Universal.instance.firstMng.next.next;
                        newfirstRowNode.nextRow = Universal.instance.firstMng.nextRow;
                        Universal.instance.firstMng = newfirstRowNode;
                        return true;
                    }
                    else if (Convert.ToUInt64(id) == Universal.instance.lastMng.info.id)//Means that we wanna delete the last Student
                    {
                        RowNode<Manager> newlasttRowNode = new RowNode<Manager>();
                        if (Universal.instance.lastMng.next != null) // Checking if we have convertable node to RowNode
                        {
                            newlasttRowNode.info = Universal.instance.lastMng.next.info;
                            newlasttRowNode.next = Universal.instance.lastMng.next.next;
                            Universal.instance.lastMng = newlasttRowNode;
                            return true;
                        }
                        else // Here we don't have convertable node to RowNode
                        {
                            RowNode<Manager> lastMng = Universal.instance.lastMng;
                            while (lastMng.nextRow != null)
                            {
                                lastMng = lastMng.nextRow;
                            }
                            Universal.instance.lastMng = lastMng;
                            return true;
                        }
                    }
                    else // Here we want to delete the students in which there are at the Middle Nodes
                    {
                        RowNode<Manager> prev = new RowNode<Manager>();
                        prev = SearchPrevManager(id);
                        if (prev != null) //if the student exists
                        {
                            if (prev.nextRow != null)//Prev is RowNode
                            {

                                if (prev.nextRow.info.id == Convert.ToUInt64(id))//Deleting node is nextRowNode
                                {
                                    if (prev.nextRow.next != null)//if the deleting RowNode has nextNode
                                    {
                                        prev.nextRow.info = prev.nextRow.next.info;
                                        prev.nextRow.next = prev.nextRow.next.next;
                                    }
                                    else //deleting RowNode doesn't have nextNode
                                    {
                                        prev.nextRow = prev.nextRow.nextRow;
                                    }
                                }
                                else // Deleting node is nextNode
                                {
                                    prev.next = prev.next.next;
                                }
                            }
                            else //Prev is not RowNode = Usual Node 
                            {
                                prev.next = prev.next.next;
                            }
                        }
                        else // Student doesn't exist
                        {
                            return false;
                        }
                        return false;
                    }

                }
                else // We have just one student 
                {
                    Universal.instance.firstMng = null;
                    Universal.instance.lastMng = null;
                    return true;
                }
            }
            else
            {
                //Showing Error that the insterted id is wrong
                return false;
            }
            //End of Method
        }
        public void EnablingUnitChoice()
        {
            Universal.instance.isAbleUnitChoice = true;
            //End of Method
        }
        public void DesablingUnitChoice()
        {
            Universal.instance.isAbleUnitChoice = false;
            //End of Method
        }
        public static bool isNumber(string id)
        {
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] < 48 || id[i] > 57)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isValidName(string name)
        {
            if (name == "") return false;
            return true;
        }
        public void RemoveStudentsSemester(String id)
        {
            Node<Student> std;
            std = SearchStudent(id);
            if (std != null)
            {
                std.info.choosenLessons.Clear();
            }
            //End of Method
        }
        public void EndingSemester()
        {

            RowNode<Student> pstd = Universal.instance.firstStd;
            Node<Student> std = pstd;
            while (pstd != null)
            {
              
                if (std.info.choosenLessons != null && std.info.choosenLessons.Count != 0)
                {
                    while (std != null)
                    {

                        for (int i = 0; i < std.info.choosenLessons.Count; i++)
                        {
                            if (std.info.choosenLessons[i].grade > 10)
                            {
                                std.info.passedLessons.Add(std.info.choosenLessons[i]);
                            }
                        }
                        std.info.choosenLessons.Clear();
                        std = std.next;

                    }
                }
                pstd = pstd.nextRow;
            }
            //End of Method
        }
    }

}
