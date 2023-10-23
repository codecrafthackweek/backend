use CodeCraftDB;

INSERT INTO Courses (Name, Tag ) VALUES ('Investimento', 'Basico');
INSERT INTO Subtopics (Name, Specification, CourseId ) VALUES ('Tesouro Direto', 'Risco baixo ou moderado', 1);
INSERT INTO Quizs (Question, Answer, SubtopicId ) VALUES ('É bom?', 'Depende', 1);
INSERT INTO Contents( Description, SubtopicId) VALUES ('O Tesouro Direto é um programa do governo que permite que você faça investimentos em Títulos Públicos. Basicamente, você empresta dinheiro ao governo e, em troca, ele paga juros sobre esse empréstimo. Isso é uma ótima opção para quem está começando a investir.', 1);