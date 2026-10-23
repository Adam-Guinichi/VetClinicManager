-- ============================================================
-- Database: CliniqueVeterinaire
-- ============================================================

-- Table: Utilisateur (users with roles)
CREATE TABLE Utilisateur (
    Id_Utilisateur INT IDENTITY(1,1) PRIMARY KEY,
    Nom NVARCHAR(50) NOT NULL,
    Prenom NVARCHAR(50) NOT NULL,
    Login NVARCHAR(50) UNIQUE NOT NULL,
    MotDePasse NVARCHAR(255) NOT NULL, -- In production, store hashed password
    Role NVARCHAR(20) NOT NULL CHECK (Role IN ('Administrateur', 'Secretaire', 'Veterinaire')),
    DateCreation DATETIME DEFAULT GETDATE()
);

-- Table: Proprietaire (animal owners)
CREATE TABLE Proprietaire (
    Id_Proprietaire INT IDENTITY(1,1) PRIMARY KEY,
    Nom NVARCHAR(50) NOT NULL,
    Prenom NVARCHAR(50) NOT NULL,
    Adresse NVARCHAR(200),
    Telephone NVARCHAR(20),
    Email NVARCHAR(100),
    DateInscription DATETIME DEFAULT GETDATE()
);

-- Table: Animal
CREATE TABLE Animal (
    Id_Animal INT IDENTITY(1,1) PRIMARY KEY,
    Nom NVARCHAR(50) NOT NULL,
    Espece NVARCHAR(50) NOT NULL,
    Race NVARCHAR(50),
    DateNaissance DATE,
    Sexe CHAR(1) CHECK (Sexe IN ('M', 'F')),
    Id_Proprietaire INT NOT NULL,
    FOREIGN KEY (Id_Proprietaire) REFERENCES Proprietaire(Id_Proprietaire) ON DELETE CASCADE
);

-- Table: RendezVous (appointments)
CREATE TABLE RendezVous (
    Id_RendezVous INT IDENTITY(1,1) PRIMARY KEY,
    DateHeure DATETIME NOT NULL,
    Motif NVARCHAR(200),
    Statut NVARCHAR(20) DEFAULT 'Planifie' CHECK (Statut IN ('Planifie', 'Modifie', 'Annule')),
    Id_Animal INT NOT NULL,
    Id_Veterinaire INT NOT NULL, -- reference Utilisateur with role Veterinaire
    Id_Secretaire INT, -- optional, who created/modified
    FOREIGN KEY (Id_Animal) REFERENCES Animal(Id_Animal) ON DELETE CASCADE,
    FOREIGN KEY (Id_Veterinaire) REFERENCES Utilisateur(Id_Utilisateur),
    FOREIGN KEY (Id_Secretaire) REFERENCES Utilisateur(Id_Utilisateur)
);

-- Table: Consultation
CREATE TABLE Consultation (
    Id_Consultation INT IDENTITY(1,1) PRIMARY KEY,
    DateHeure DATETIME NOT NULL DEFAULT GETDATE(),
    Diagnostic NVARCHAR(MAX),
    Traitement NVARCHAR(MAX),
    Remarques NVARCHAR(MAX),
    Id_RendezVous INT UNIQUE, -- optional, if consultation comes from an appointment
    Id_Veterinaire INT NOT NULL,
    FOREIGN KEY (Id_RendezVous) REFERENCES RendezVous(Id_RendezVous) ON DELETE SET NULL,
    FOREIGN KEY (Id_Veterinaire) REFERENCES Utilisateur(Id_Utilisateur)
);

-- Table: Vaccination
CREATE TABLE Vaccination (
    Id_Vaccination INT IDENTITY(1,1) PRIMARY KEY,
    Id_Animal INT NOT NULL,
    Id_Veterinaire INT NOT NULL,
    Vaccin NVARCHAR(100) NOT NULL,
    DateAdministration DATE NOT NULL,
    DateRappel DATE, -- next due date
    FOREIGN KEY (Id_Animal) REFERENCES Animal(Id_Animal) ON DELETE CASCADE,
    FOREIGN KEY (Id_Veterinaire) REFERENCES Utilisateur(Id_Utilisateur)
);

-- Table: Medicament (medicines inventory)
CREATE TABLE Medicament (
    Id_Medicament INT IDENTITY(1,1) PRIMARY KEY,
    Nom NVARCHAR(100) NOT NULL,
    Description NVARCHAR(MAX),
    QuantiteStock INT NOT NULL DEFAULT 0,
    SeuilAlerte INT NOT NULL DEFAULT 5,
    DateExpiration DATE,
    Unite NVARCHAR(20) -- e.g., "comprimé", "ml"
);

-- Table: Consultation_Medicament (junction table for treatments given during consultation)
CREATE TABLE Consultation_Medicament (
    Id_Consultation INT NOT NULL,
    Id_Medicament INT NOT NULL,
    Quantite INT NOT NULL,
    PRIMARY KEY (Id_Consultation, Id_Medicament),
    FOREIGN KEY (Id_Consultation) REFERENCES Consultation(Id_Consultation) ON DELETE CASCADE,
    FOREIGN KEY (Id_Medicament) REFERENCES Medicament(Id_Medicament)
);

-- Table: Facture (invoices)
CREATE TABLE Facture (
    Id_Facture INT IDENTITY(1,1) PRIMARY KEY,
    Id_Consultation INT NOT NULL,
    MontantTotal DECIMAL(10,2) NOT NULL,
    DateEmission DATETIME NOT NULL DEFAULT GETDATE(),
    StatutPaiement NVARCHAR(20) DEFAULT 'Impaye' CHECK (StatutPaiement IN ('Impaye', 'Paye')),
    ModePaiement NVARCHAR(50), -- e.g., "Espèces", "Carte"
    FOREIGN KEY (Id_Consultation) REFERENCES Consultation(Id_Consultation) ON DELETE CASCADE
);

-- ============================================================
-- Indexes for performance
-- ============================================================
CREATE INDEX IX_RendezVous_Animal ON RendezVous(Id_Animal);
CREATE INDEX IX_RendezVous_Veterinaire ON RendezVous(Id_Veterinaire);
CREATE INDEX IX_Consultation_Veterinaire ON Consultation(Id_Veterinaire);
CREATE INDEX IX_Vaccination_Animal ON Vaccination(Id_Animal);
CREATE INDEX IX_Facture_Consultation ON Facture(Id_Consultation);
CREATE INDEX IX_Consultation_Medicament_Consultation ON Consultation_Medicament(Id_Consultation);
CREATE INDEX IX_Consultation_Medicament_Medicament ON Consultation_Medicament(Id_Medicament);