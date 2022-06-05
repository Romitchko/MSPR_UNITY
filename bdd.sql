CREATE TABLE prospect(
    id serial not null,
    prenom CHARACTER VARYING,
    mail CHARACTER VARYING,
    CONSTRAINT PK_Prospect PRIMARY KEY (id)
);