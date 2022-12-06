-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 20, 2020 at 01:54 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inet_bikerental`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbladsmanagement`
--

CREATE TABLE `tbladsmanagement` (
  `ads_id` int(11) NOT NULL,
  `ad_name` varchar(30) NOT NULL,
  `shop_id` int(11) NOT NULL,
  `banner_image` blob NOT NULL,
  `description` varchar(100) NOT NULL,
  `start_date` date NOT NULL,
  `end_date` date NOT NULL,
  `ad_location` int(1) NOT NULL,
  `amount` float NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tblbikecategory`
--

CREATE TABLE `tblbikecategory` (
  `category_id` int(11) NOT NULL,
  `category_name` varchar(30) NOT NULL,
  `description` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tblbikeinfo`
--

CREATE TABLE `tblbikeinfo` (
  `bike_id` int(11) NOT NULL,
  `bike_category_id` int(11) NOT NULL,
  `shop_id` int(11) NOT NULL,
  `bike_name` varchar(30) NOT NULL,
  `specs` varchar(100) NOT NULL,
  `rent_price` float NOT NULL,
  `availability` int(1) NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tblclient`
--

CREATE TABLE `tblclient` (
  `client_id` int(11) NOT NULL,
  `client_code` varchar(15) NOT NULL,
  `avatar` blob NOT NULL,
  `client_name` varchar(30) NOT NULL,
  `email_address` varchar(30) NOT NULL,
  `contact_number` varchar(15) NOT NULL,
  `complete_address` varchar(100) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `status` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblpayment`
--

CREATE TABLE `tblpayment` (
  `payment_id` int(11) NOT NULL,
  `rental_id` int(11) NOT NULL,
  `payment_type` int(1) NOT NULL,
  `paid_by` varchar(30) NOT NULL,
  `payment_date` date NOT NULL,
  `remarks` varchar(100) NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tblpenalty`
--

CREATE TABLE `tblpenalty` (
  `penalty_id` int(11) NOT NULL,
  `rental_id` int(11) NOT NULL,
  `penalty_amount` float NOT NULL,
  `payment_status` int(1) NOT NULL,
  `remarks` varchar(100) NOT NULL,
  `paid_by` varchar(30) NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tblrental`
--

CREATE TABLE `tblrental` (
  `rental_id` int(11) NOT NULL,
  `bike_id` int(11) NOT NULL,
  `client_id` int(11) NOT NULL,
  `rental_start_date` date NOT NULL,
  `rental_end_date` date NOT NULL,
  `total_amount` float NOT NULL,
  `payment_status` int(1) NOT NULL,
  `rental_status` int(1) NOT NULL,
  `remarks` varchar(100) NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tblshopinfo`
--

CREATE TABLE `tblshopinfo` (
  `shop_id` int(11) NOT NULL,
  `shop_name` varchar(50) NOT NULL,
  `owner_name` varchar(30) NOT NULL,
  `address` varchar(100) NOT NULL,
  `email_address` varchar(30) NOT NULL,
  `contact_no` varchar(15) NOT NULL,
  `website` varchar(30) NOT NULL,
  `updated_by` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `user_id` int(11) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `avatar` blob NOT NULL,
  `fullname` varchar(50) NOT NULL,
  `contact` varchar(15) NOT NULL,
  `email` varchar(30) NOT NULL,
  `user_category_id` int(1) NOT NULL,
  `status` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblusergroup`
--

CREATE TABLE `tblusergroup` (
  `user_group_id` int(11) NOT NULL,
  `group_name` varchar(30) NOT NULL,
  `description` varchar(50) NOT NULL,
  `allow_add` int(1) NOT NULL,
  `allow_edit` int(1) NOT NULL,
  `allow_delete` int(1) NOT NULL,
  `allow_print` int(1) NOT NULL,
  `allow_import` int(1) NOT NULL,
  `allow_export` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbladsmanagement`
--
ALTER TABLE `tbladsmanagement`
  ADD PRIMARY KEY (`ads_id`),
  ADD KEY `shop_id` (`shop_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `tblbikecategory`
--
ALTER TABLE `tblbikecategory`
  ADD PRIMARY KEY (`category_id`);

--
-- Indexes for table `tblbikeinfo`
--
ALTER TABLE `tblbikeinfo`
  ADD PRIMARY KEY (`bike_id`),
  ADD KEY `bike_category_id` (`bike_category_id`),
  ADD KEY `shop_id` (`shop_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `tblclient`
--
ALTER TABLE `tblclient`
  ADD PRIMARY KEY (`client_id`);

--
-- Indexes for table `tblpayment`
--
ALTER TABLE `tblpayment`
  ADD PRIMARY KEY (`payment_id`),
  ADD KEY `rental_id` (`rental_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `tblpenalty`
--
ALTER TABLE `tblpenalty`
  ADD PRIMARY KEY (`penalty_id`),
  ADD KEY `rental_id` (`rental_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `tblrental`
--
ALTER TABLE `tblrental`
  ADD PRIMARY KEY (`rental_id`),
  ADD KEY `bike_id` (`bike_id`),
  ADD KEY `client_id` (`client_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `tblshopinfo`
--
ALTER TABLE `tblshopinfo`
  ADD PRIMARY KEY (`shop_id`),
  ADD KEY `updated_by` (`updated_by`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`user_id`),
  ADD KEY `user_category_id` (`user_category_id`);

--
-- Indexes for table `tblusergroup`
--
ALTER TABLE `tblusergroup`
  ADD PRIMARY KEY (`user_group_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbladsmanagement`
--
ALTER TABLE `tbladsmanagement`
  MODIFY `ads_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblbikecategory`
--
ALTER TABLE `tblbikecategory`
  MODIFY `category_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblbikeinfo`
--
ALTER TABLE `tblbikeinfo`
  MODIFY `bike_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblclient`
--
ALTER TABLE `tblclient`
  MODIFY `client_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblpayment`
--
ALTER TABLE `tblpayment`
  MODIFY `payment_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblpenalty`
--
ALTER TABLE `tblpenalty`
  MODIFY `penalty_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblrental`
--
ALTER TABLE `tblrental`
  MODIFY `rental_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblshopinfo`
--
ALTER TABLE `tblshopinfo`
  MODIFY `shop_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbluser`
--
ALTER TABLE `tbluser`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblusergroup`
--
ALTER TABLE `tblusergroup`
  MODIFY `user_group_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbladsmanagement`
--
ALTER TABLE `tbladsmanagement`
  ADD CONSTRAINT `tbladsmanagement_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `tbluser` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbladsmanagement_ibfk_2` FOREIGN KEY (`shop_id`) REFERENCES `tblshopinfo` (`shop_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tblbikeinfo`
--
ALTER TABLE `tblbikeinfo`
  ADD CONSTRAINT `tblbikeinfo_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `tbluser` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tblbikeinfo_ibfk_2` FOREIGN KEY (`bike_category_id`) REFERENCES `tblbikecategory` (`category_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tblbikeinfo_ibfk_3` FOREIGN KEY (`shop_id`) REFERENCES `tblshopinfo` (`shop_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tblpayment`
--
ALTER TABLE `tblpayment`
  ADD CONSTRAINT `tblpayment_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `tbluser` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tblpayment_ibfk_2` FOREIGN KEY (`rental_id`) REFERENCES `tblrental` (`rental_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tblpenalty`
--
ALTER TABLE `tblpenalty`
  ADD CONSTRAINT `tblpenalty_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `tbluser` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tblpenalty_ibfk_2` FOREIGN KEY (`rental_id`) REFERENCES `tblrental` (`rental_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tblrental`
--
ALTER TABLE `tblrental`
  ADD CONSTRAINT `tblrental_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `tbluser` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tblrental_ibfk_2` FOREIGN KEY (`bike_id`) REFERENCES `tblbikeinfo` (`bike_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tblrental_ibfk_3` FOREIGN KEY (`client_id`) REFERENCES `tblclient` (`client_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tblshopinfo`
--
ALTER TABLE `tblshopinfo`
  ADD CONSTRAINT `tblshopinfo_ibfk_1` FOREIGN KEY (`updated_by`) REFERENCES `tbluser` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD CONSTRAINT `tbluser_ibfk_1` FOREIGN KEY (`user_category_id`) REFERENCES `tblusergroup` (`user_group_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
