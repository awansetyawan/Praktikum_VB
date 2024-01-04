-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 11 Apr 2023 pada 08.20
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
-- Struktur dari tabel `dataservice`
--

CREATE TABLE `dataservice` (
  `id` int(5) NOT NULL,
  `merek` varchar(100) NOT NULL,
  `seri` varchar(100) NOT NULL,
  `customer` varchar(100) NOT NULL,
  `nohp` varchar(15) NOT NULL,
  `kerusakan` varchar(100) NOT NULL,
  `tanggal` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `dataservice`
--

INSERT INTO `dataservice` (`id`, `merek`, `seri`, `customer`, `nohp`, `kerusakan`, `tanggal`) VALUES
(101, 'Acer', 'Nitro', 'Awan', '08123', 'Software', '2023-04-30'),
(102, 'Asus', 'ROG', 'Alif', '08321', 'Hardware', '2023-04-20');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `dataservice`
--
ALTER TABLE `dataservice`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `dataservice`
--
ALTER TABLE `dataservice`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=110;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
