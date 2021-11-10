-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2021. Nov 08. 10:09
-- Kiszolgáló verziója: 10.4.19-MariaDB
-- PHP verzió: 7.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `jarmuvek`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `auto`
--

CREATE TABLE `auto` (
  `Márka` varchar(128) NOT NULL,
  `Km óra állás` int(11) NOT NULL,
  `Gyártási idő` date NOT NULL,
  `Szín` varchar(128) NOT NULL,
  `Típus` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `auto`
--

INSERT INTO `auto` (`Márka`, `Km óra állás`, `Gyártási idő`, `Szín`, `Típus`) VALUES
('BMW', 126888, '2012-06-13', 'Fekete', 'Kombi'),
('Audi', 93722, '2018-12-10', 'Piros', 'Cabrio');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `motor`
--

CREATE TABLE `motor` (
  `Márka` varchar(128) NOT NULL,
  `Km óra állás` int(11) NOT NULL,
  `Gyártási idő` date NOT NULL,
  `Motor típus` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `motor`
--

INSERT INTO `motor` (`Márka`, `Km óra állás`, `Gyártási idő`, `Motor típus`) VALUES
('Honda', 6300, '2007-08-22', 'Túra'),
('Yamaha', 3530, '2011-03-15', 'Sport');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
