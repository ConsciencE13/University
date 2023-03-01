CREATE TABLE GAR_t (
    ID NUMBER(3) PRIMARY KEY,
    name VARCHAR2(50)
);

INSERT INTO gar_t VALUES (10, 'Andrey');
INSERT INTO gar_t VALUES (11, 'Dmitry');
INSERT INTO gar_t VALUES (12, 'Andrey');
COMMIT;

UPDATE gar_t SET name = 'Alex' WHERE name = 'Andrey';
COMMIT;

SELECT ID, COUNT(name) FROM gar_t
WHERE ID < 12
GROUP BY ID;

DELETE FROM gar_t WHERE ID = 12;
ROLLBACK;

CREATE TABLE GAR_t_child (
    person_ID NUMBER(3),
    phone_number VARCHAR2(20),
    CONSTRAINT FK_PersonOrder FOREIGN KEY (person_ID)
    REFERENCES gar_t(ID)
);

INSERT INTO GAR_t_child VALUES (11, '+375291110202');
INSERT INTO GAR_t_child VALUES (11, '+375441899001');

SELECT gar_t.ID, GAR_t_child.phone_number
FROM gar_t INNER JOIN GAR_t_child
ON ID = person_ID;

DROP TABLE GAR_t_child;
DROP TABLE gar_t;