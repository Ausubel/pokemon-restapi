USE master;
GO

CREATE DATABASE db_pokemon;
GO

USE db_pokemon;
GO
    
CREATE TABLE pokemonType (
    id INT,
    name NVARCHAR(50) NOT NULL,
    CONSTRAINT pk_pokemonType PRIMARY KEY (id)
);
GO

CREATE TABLE pokemonDiet (
    id INT,
    description NVARCHAR(50) NOT NULL,
    CONSTRAINT pk_pokemonDiet PRIMARY KEY (id)
);
GO

CREATE TABLE pokemonSize (
    id INT,
    description NVARCHAR(50) NOT NULL,
    CONSTRAINT pk_pokemonSize PRIMARY KEY (id)
);
GO

CREATE TABLE pokemonRarity (
    id INT,
    name NVARCHAR(50) NOT NULL,
    CONSTRAINT pk_pokemonRarity PRIMARY KEY (id)
);
GO

CREATE TABLE pokemon (
    id INT IDENTITY(1,1) NOT NULL,
    name NVARCHAR(50) NOT NULL,
    typeId INT NOT NULL,
    dietId INT NOT NULL,
    sizeId INT NOT NULL,
    weightKg NVARCHAR(10) NOT NULL,
    rarityId INT NOT NULL,
    funFact NVARCHAR(100) NOT NULL,
    CONSTRAINT pk_pokemon PRIMARY KEY (id),
    CONSTRAINT fk_pokemonType FOREIGN KEY (typeId) REFERENCES pokemonType(id),
    CONSTRAINT fk_pokemonDiet FOREIGN KEY (dietId) REFERENCES pokemonDiet(id),
    CONSTRAINT fk_pokemonSize FOREIGN KEY (sizeId) REFERENCES pokemonSize(id),
    CONSTRAINT fk_pokemonRarity FOREIGN KEY (rarityId) REFERENCES pokemonRarity(id)
);
GO

-- INSERTS pokemonType
INSERT INTO pokemonType (id, name)
VALUES
    (1, 'Eléctrico'),
    (2, 'Planta/Veneno'),
    (3, 'Fuego'),
    (4, 'Agua'),
    (5, 'Normal/Hada'),
    (6, 'Normal'),
    (7, 'Lucha'),
    (8, 'Psíquico'),
    (9, 'Fantasma/Veneno'),
    (10, 'Roca/Tierra'),
    (11, 'Planta/Psíquico'),
    (12, 'Veneno'),
    (13, 'Tierra'),
    (14, 'Hielo/Psíquico'),
    (15, 'Agua/Hielo'),
    (16, 'Dragón/Volador'),
    (17, 'Eléctrico/Volador'),
    (18, 'Fuego/Volador'),
    (19, 'Hielo/Volador');
GO

-- INSERTS pokemonDiet
INSERT INTO pokemonDiet (id, description)
VALUES
    (1, 'Omnívoro'),
    (2, 'Herbívoro'),
    (3, 'Carnívoro');
GO
-- INSERTS pokemonSize
INSERT INTO pokemonSize (id, description)
VALUES
    (1, 'Pequeño'),
    (2, 'Mediano'),
    (3, 'Grande');
GO
-- INSERTS pokemonRarity
INSERT INTO pokemonRarity (id, name)
VALUES
    (1, 'Común'),
    (2, 'Poco Común'),
    (3, 'Raro'),
    (4, 'Legendario');
GO
-- INSERTS pokemon
INSERT INTO pokemon (name, weightKg, funFact, typeId, dietId, sizeId, rarityId) 
VALUES
('Pikachu', '6.0 kg', 'Siempre tiene energía estática en su cuerpo.', 1, 1, 1, 1),
('Bulbasaur', '6.9 kg', 'El bulbo en su espalda puede absorber nutrientes del sol.', 2, 2, 1, 1),
('Charmander', '8.5 kg', 'La llama en su cola indica su estado emocional.', 3, 3, 1, 1),
('Squirtle', '9.0 kg', 'Puede disparar agua a alta presión desde su boca.', 4, 3, 1, 1),
('Jigglypuff', '5.5 kg', 'Canta una canción de cuna que hace dormir a quien la escucha.', 5, 2, 1, 1),
('Meowth', '4.2 kg', 'Le encantan las monedas brillantes.', 6, 3, 1, 1),
('Psyduck', '19.6 kg', 'Siempre tiene dolor de cabeza.', 4, 1, 1, 1),
('Machop', '19.5 kg', 'Entrena levantando rocas.', 7, 3, 2, 2),
('Abra', '19.5 kg', 'Puede leer la mente de otros.', 8, 3, 1, 2),
('Gastly', '0.1 kg', 'Está compuesto por gases venenosos.', 9, 3, 1, 2),
('Onix', '210.0 kg', 'Vive en cuevas subterráneas.', 10, 2, 3, 2),
('Drowzee', '32.4 kg', 'Se alimenta de los sueños de las personas.', 8, 1, 2, 2),
('Exeggcute', '2.5 kg', 'Consiste en seis huevos de semillas.', 11, 2, 1, 2),
('Koffing', '1.0 kg', 'Se infla para aumentar su tamaño.', 12, 3, 1, 2),
('Cubone', '6.5 kg', 'Lleva una calavera de su madre fallecida.', 13, 3, 1, 2),
('Snorlax', '460.0 kg', 'Puede dormir durante días seguidos.', 6, 2, 3, 3),
('Jynx', '40.6 kg', 'Su baile hipnotiza a sus oponentes.', 14, 3, 2, 3),
('Lapras', '220.0 kg', 'Es conocido por su dulce canto.', 15, 2, 3, 3),
('Dragonite', '210.0 kg', 'Puede volar a grandes velocidades.', 16, 3, 3, 3),
('Mewtwo', '122.0 kg', 'Fue creado artificialmente en un laboratorio.', 8, 3, 2, 4),
('Mew', '4.0 kg', 'Contiene el ADN de todos los Pokémon.', 8, 1, 1, 4),
('Zapdos', '52.6 kg', 'Su cuerpo genera electricidad estática.', 17, 3, 3, 4),
('Moltres', '60.0 kg', 'Tiene la habilidad de controlar el fuego.', 18, 3, 3, 4),
('Articuno',     '55.4 kg', 'Puede congelar el aire a su alrededor.', 19, 3, 3, 4);
GO
