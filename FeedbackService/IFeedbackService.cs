using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FeedbackService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IFeedbackService
    {
        [OperationContract]
        [FaultContract(typeof(CustomException))]
        Student GetStudentByStudentid(int studentId);

        [OperationContract]
        [FaultContract(typeof(CustomException))]
        int AddStudent(Student student);

        [OperationContract]
        [FaultContract(typeof(CustomException))]
        int AddCourse(Course course);

        [OperationContract]
        [FaultContract(typeof(CustomException))]
        List<Course> GetCourses();

        [OperationContract]
        [FaultContract(typeof(CustomException))]
        Course GetCourseByCourseId(int courseId);

        [OperationContract]
        [FaultContract(typeof(CustomException))]
        int AddStudentCourse(StudentCourse course);

        [OperationContract]
        [FaultContract(typeof(CustomException))]
        List<StudentCourse> GetStudentCourseByStudentId(int studentId);

        [OperationContract]
        [FaultContract(typeof(CustomException))]
        int AddFeedBack(Feedback feedback);

        [OperationContract]
        [FaultContract(typeof(CustomException))]
        List<Feedback> GetFeedbackByCourseId(int courseId);

        [OperationContract]
        [FaultContract(typeof(CustomException))]
        List<Feedback> GetFeedbackByCourseName(string courseName);

        [OperationContract]
        [FaultContract(typeof(CustomException))]
        List<Feedback> GetFeedbackByStudentId(int studentId);

        [OperationContract]
        [FaultContract(typeof(CustomException))]
        List<Feedback> GetFeedbackById(int feedbackId);

        [OperationContract]
        [FaultContract(typeof(CustomException))]
        int UpdateFeedbackById(int studentId, string feedback, DateTime modifiedDate);
    }   
}
