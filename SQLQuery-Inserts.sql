use CodeCraftDB;

INSERT INTO Courses (Name, Tag ) VALUES ('Investimento', 'Basico');
INSERT INTO Subtopics (Name, Specification, CourseId ) VALUES ('Tesouro Direto', 'Risco baixo ou moderado', 1);
INSERT INTO Quizs (Question, Answer, SubtopicId ) VALUES ('� bom?', 'Depende', 1);
INSERT INTO Contents( Description, SubtopicId) VALUES ('O Tesouro Direto � um programa do governo que permite que voc� fa�a investimentos em T�tulos P�blicos. Basicamente, voc� empresta dinheiro ao governo e, em troca, ele paga juros sobre esse empr�stimo. Isso � uma �tima op��o para quem est� come�ando a investir.', 1);