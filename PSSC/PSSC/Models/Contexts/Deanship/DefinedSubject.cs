﻿using Models.Common.Subject;
using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Contexts.Deanship
{/*
     * Entity
     * A DefinedSubject is a class which describes every aspect of a subject, such as:
     * 1. The professor
     * 2. The exam type
     * 3. The activity proportion (when calculating the average)
     * 4. The enrolled students for the current subject and their subject situation
     */
    public class DefinedSubject : Subject
    {
        public Common.Professor.Professor Professor { get; internal set; }
        public EvaluationType ExamType { get; internal set; }
        public Proportion Proportion { get; internal set; }

        private Dictionary<Common.Student.Student, ViewableSituation> _enrolledStudents { get; set; }

        public DefinedSubject(PlainText subjectName, Credits credits, EvaluationType examType, Common.Professor.Professor professor,
             Dictionary<Common.Student.Student, ViewableSituation> enrolledStudents) : base(subjectName, credits)
        {
            ExamType = examType;
            Professor = professor;

            _enrolledStudents = enrolledStudents;
        }

        public DefinedSubject(PlainText subjectName, Credits credits, EvaluationType examType, Common.Professor.Professor professor, 
            Proportion proportion, Dictionary<Common.Student.Student, ViewableSituation> enrolledStudents)
            : this(subjectName, credits, examType, professor, proportion)
        {
            _enrolledStudents = enrolledStudents;
        }

        public DefinedSubject(PlainText subjectName, Credits credits, EvaluationType examType, Common.Professor.Professor professor, 
            Proportion proportion) : base(subjectName, credits)
        {
            ExamType = examType;
            Professor = professor;
            Proportion = proportion;

            _enrolledStudents = new Dictionary<Common.Student.Student, ViewableSituation>();
        }

        public void EnrollStudent(Common.Student.Student student)
        {
            _enrolledStudents.Add(student, new ViewableSituation(student.RegNumber));
        }

        public Grade GetStudentAverage(RegistrationNumber regNumber)
        {
            return _enrolledStudents.First(d => d.Key.RegNumber == regNumber).Value.GetExamAverage();
        }

        public void ChangeProfessor(Common.Professor.Professor professor)
        {
            Professor = professor;
        }

        public ViewableSituation GetStudentSituation(RegistrationNumber regNumber)
        {
            return _enrolledStudents.First(d => d.Key.RegNumber == regNumber).Value;
        }
    }
}
