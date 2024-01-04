-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 16 Apr 2023 pada 11.28
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_pendataanservice`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `dataakun`
--

CREATE TABLE `dataakun` (
  `KodeUser` int(5) NOT NULL,
  `Username` varchar(100) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `StatusUser` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `dataakun`
--

INSERT INTO `dataakun` (`KodeUser`, `Username`, `Password`, `StatusUser`) VALUES
(1, 'Awan', '123', 'ADMIN');

-- --------------------------------------------------------

--
-- Struktur dari tabel `dataservice`
--

CREATE TABLE `dataservice` (
  `id` int(5) NOT NULL,
  `merek` varchar(100) NOT NULL,
  `seri` varchar(100) NOT NULL,
  `customer` varchar(100) NOT NULL,
  `nohp` varchar(15) NOT NULL,
  `kerusakan` varchar(100) NOT NULL,
  `tanggal` date NOT NULL,
  `IdTeknisi` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `datateknisi`
--

CREATE TABLE `datateknisi` (
  `IdTeknisi` int(5) NOT NULL,
  `NamaTeknisi` varchar(100) NOT NULL,
  `Keahlian` varchar(100) NOT NULL,
  `NoHp` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `dataakun`
--
ALTER TABLE `dataakun`
  ADD PRIMARY KEY (`KodeUser`);

--
-- Indeks untuk tabel `dataservice`
--
ALTER TABLE `dataservice`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `datateknisi`
--
ALTER TABLE `datateknisi`
  ADD PRIMARY KEY (`IdTeknisi`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `dataakun`
--
ALTER TABLE `dataakun`
  MODIFY `KodeUser` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT untuk tabel `dataservice`
--
ALTER TABLE `dataservice`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=110;

--
-- AUTO_INCREMENT untuk tabel `datateknisi`
--
ALTER TABLE `datateknisi`
  MODIFY `IdTeknisi` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=103;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
