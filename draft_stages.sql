-- Généré par Oracle SQL Developer Data Modeler 4.0.0.820
--   à :        2014-03-04 13:55:50 EST
--   site :      Oracle Database 11g
--   type :      Oracle Database 11g

CREATE TABLE Entreprises
  (
    NumEnt       NUMBER (3) NOT NULL ,
    NomEnt       VARCHAR2 (20) NOT NULL ,
    NomContact   VARCHAR2 (30) NOT NULL ,
    TailleEnt    NUMBER (3) ,
    TypeEnt      VARCHAR2 (20) ,
    AdresseEnt   VARCHAR2 (50) ,
    CourielEnt   VARCHAR2 (30) ,
    TelephoneEnt VARCHAR2 (20) ,
    CoteEnt      NUMBER (2)
  ) ;
ALTER TABLE Entreprises ADD CONSTRAINT Entreprises_PK PRIMARY KEY ( NumEnt ) ;

CREATE TABLE Stages
  (
    NumStage     NUMBER (5) NOT NULL ,
    NbStagiaires NUMBER (2) NOT NULL ,
    Plateforme   VARCHAR2 (20) ,
    Logiciel     VARCHAR2 (20) ,
    TypeStage    VARCHAR2 (20) ,
    DescrStage   VARCHAR2 (20) ,
    NumEnt       NUMBER (3) NOT NULL
  ) ;
ALTER TABLE Stages ADD CONSTRAINT Stages_PK PRIMARY KEY ( NumStage ) ;

CREATE TABLE Stagiaires
  (
    NumAd            NUMBER (9) NOT NULL ,
    NomEtudiant      VARCHAR2 (20) NOT NULL ,
    PrenomEtudiant   VARCHAR2 (20) NOT NULL ,
    Specialisation   VARCHAR2 (10) NOT NULL ,
    CourrielEtudiant VARCHAR2 (20)
  ) ;
ALTER TABLE Stagiaires ADD CONSTRAINT Stagiaires_PK PRIMARY KEY ( NumAd ) ;

CREATE TABLE Assignations
  (
    NumAd     NUMBER (9) NOT NULL ,
    NumStage  NUMBER (5) NOT NULL ,
    DateDebut DATE ,
    DateFin   DATE
  ) ;
ALTER TABLE Assignations ADD CONSTRAINT Assignation_PK PRIMARY KEY ( NumAd, NumStage ) ;

--Autres contraintes
ALTER TABLE Assignations ADD CONSTRAINT Assignation_Stages_FK FOREIGN KEY ( NumStage ) REFERENCES Stages ( NumStage ) ;

ALTER TABLE Assignations ADD CONSTRAINT Assignation_Stagiaires_FK FOREIGN KEY ( NumAd ) REFERENCES Stagiaires ( NumAd ) ;

ALTER TABLE Stages ADD CONSTRAINT Stages_Entreprises_FK FOREIGN KEY ( NumEnt ) REFERENCES Entreprises ( NumEnt ) ;


-- Rapport récapitulatif d'Oracle SQL Developer Data Modeler : 
-- 
-- CREATE TABLE                             4
-- CREATE INDEX                             0
-- ALTER TABLE                              7
-- CREATE VIEW                              0
-- CREATE PACKAGE                           0
-- CREATE PACKAGE BODY                      0
-- CREATE PROCEDURE                         0
-- CREATE FUNCTION                          0
-- CREATE TRIGGER                           0
-- ALTER TRIGGER                            0
-- CREATE COLLECTION TYPE                   0
-- CREATE STRUCTURED TYPE                   0
-- CREATE STRUCTURED TYPE BODY              0
-- CREATE CLUSTER                           0
-- CREATE CONTEXT                           0
-- CREATE DATABASE                          0
-- CREATE DIMENSION                         0
-- CREATE DIRECTORY                         0
-- CREATE DISK GROUP                        0
-- CREATE ROLE                              0
-- CREATE ROLLBACK SEGMENT                  0
-- CREATE SEQUENCE                          0
-- CREATE MATERIALIZED VIEW                 0
-- CREATE SYNONYM                           0
-- CREATE TABLESPACE                        0
-- CREATE USER                              0
-- 
-- DROP TABLESPACE                          0
-- DROP DATABASE                            0
-- 
-- REDACTION POLICY                         0
-- 
-- ERRORS                                   0
-- WARNINGS                                 0
