﻿namespace EF2OR.Enums
{
    public class ApiEndPoints
    {
        public const string OauthAuthorize = "oauth/authorize";
        public const string OauthGetToken = "oauth/token";
        public const string Schools = "enrollment/schools";
        public const string Subjects = "enrollment/sections"; //acedemicSubjectDescriptor
        public const string Courses = "enrollment/sections"; //courseOfferingReference.localCourseCode
        public const string Sections = "enrollment/sections"; //uniqueSectionCode
        public const string Staff = "enrollment/staffs";
        //public const string Teachers = "enrollment/sectionEnrollments"; //staff.firstName + staff.lastSurname
        public const string SchoolYears = "enrollment/sections"; //sessionReference.schoolYear
        public const string Terms = "enrollment/sections"; //sessionReference.termDescriptor

        public const string CsvOrgs = "enrollment/schools";
        public const string CsvUsersStudents = "enrollment/students";
        public const string CsvUsersStaff = "enrollment/staffs";
        public const string CsvUsers = "enrollment/sections";
        public const string CsvCourses = "enrollment/sections";
        public const string CsvClasses = "enrollment/sections";
        public const string CsvEnrollments = "enrollment/sections";
        public const string CsvAcademicSessions = "enrollment/sections";

    }
}