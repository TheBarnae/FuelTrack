-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 12, 2026 at 10:32 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `fueltrack_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `attendance_id` int(11) NOT NULL,
  `employee_id` int(11) NOT NULL,
  `login_time` datetime NOT NULL,
  `logout_time` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `attendance`
--

INSERT INTO `attendance` (`attendance_id`, `employee_id`, `login_time`, `logout_time`) VALUES
(1, 1, '2026-05-01 20:54:43', NULL),
(2, 1, '2026-05-01 20:55:31', NULL),
(3, 1, '2026-05-01 21:12:14', NULL),
(4, 1, '2026-05-01 21:14:59', NULL),
(5, 1, '2026-05-01 21:19:17', NULL),
(6, 1, '2026-05-01 21:19:43', NULL),
(7, 1, '2026-05-01 21:23:06', NULL),
(8, 1, '2026-05-01 21:23:43', NULL),
(9, 1, '2026-05-01 21:26:12', NULL),
(10, 1, '2026-05-01 21:27:01', NULL),
(11, 1, '2026-05-01 21:27:19', NULL),
(12, 1, '2026-05-01 21:30:53', NULL),
(13, 1, '2026-05-01 21:33:01', NULL),
(14, 1, '2026-05-01 21:35:22', NULL),
(15, 1, '2026-05-01 21:37:16', NULL),
(16, 1, '2026-05-01 21:40:43', NULL),
(17, 1, '2026-05-01 21:41:28', NULL),
(18, 1, '2026-05-02 01:47:15', NULL),
(19, 1, '2026-05-02 01:52:05', NULL),
(20, 1, '2026-05-02 02:24:32', NULL),
(21, 1, '2026-05-03 22:38:22', NULL),
(22, 1, '2026-05-03 22:41:11', NULL),
(23, 1, '2026-05-03 22:44:34', NULL),
(24, 1, '2026-05-03 22:46:06', NULL),
(25, 1, '2026-05-03 23:19:24', NULL),
(26, 1, '2026-05-03 23:31:08', NULL),
(27, 1, '2026-05-03 23:37:15', NULL),
(28, 1, '2026-05-03 23:39:14', NULL),
(29, 1, '2026-05-03 23:46:21', NULL),
(30, 1, '2026-05-03 23:49:10', NULL),
(31, 1, '2026-05-05 04:17:42', NULL),
(32, 1, '2026-05-05 04:20:52', NULL),
(33, 1, '2026-05-05 04:33:38', NULL),
(34, 1, '2026-05-12 21:17:40', NULL),
(35, 1, '2026-05-12 21:24:47', NULL),
(36, 1, '2026-05-12 21:34:25', NULL),
(37, 1, '2026-05-12 22:01:01', NULL),
(38, 1, '2026-05-12 22:01:55', NULL),
(39, 1, '2026-05-12 22:17:05', NULL),
(40, 1, '2026-05-12 22:42:48', NULL),
(41, 1, '2026-05-12 22:50:32', NULL),
(42, 1, '2026-05-12 22:58:36', NULL),
(43, 1, '2026-05-12 22:59:02', NULL),
(44, 1, '2026-05-12 23:03:20', NULL),
(45, 1, '2026-05-12 23:06:01', NULL),
(46, 1, '2026-05-12 23:17:58', NULL),
(47, 1, '2026-05-12 23:21:29', NULL),
(48, 1, '2026-05-12 23:34:28', NULL),
(49, 1, '2026-05-12 23:39:01', NULL),
(50, 1, '2026-05-12 23:40:40', NULL),
(51, 1, '2026-05-12 23:46:07', NULL),
(52, 1, '2026-05-12 23:58:00', NULL),
(53, 1, '2026-05-13 00:11:08', NULL),
(54, 1, '2026-05-13 00:15:00', NULL),
(55, 1, '2026-05-13 00:15:40', NULL),
(56, 1, '2026-05-13 00:16:25', NULL),
(57, 1, '2026-05-13 00:17:52', NULL),
(58, 1, '2026-05-13 00:19:04', NULL),
(59, 1, '2026-05-13 00:23:17', NULL),
(60, 1, '2026-05-13 00:29:25', NULL),
(61, 1, '2026-05-13 00:40:51', NULL),
(62, 1, '2026-05-13 00:48:35', NULL),
(63, 1, '2026-05-13 00:51:18', NULL),
(64, 1, '2026-05-13 00:54:48', NULL),
(65, 1, '2026-05-13 01:00:03', NULL),
(66, 1, '2026-05-13 01:10:21', NULL),
(67, 1, '2026-05-13 01:13:21', NULL),
(68, 1, '2026-05-13 01:22:13', NULL),
(69, 1, '2026-05-13 01:24:59', NULL),
(70, 1, '2026-05-13 01:27:23', NULL),
(71, 1, '2026-05-13 01:28:33', NULL),
(72, 1, '2026-05-13 01:30:31', NULL),
(73, 1, '2026-05-13 01:33:18', NULL),
(74, 1, '2026-05-13 01:36:33', NULL),
(75, 1, '2026-05-13 01:40:11', NULL),
(76, 1, '2026-05-13 01:40:55', NULL),
(77, 1, '2026-05-13 01:42:32', NULL),
(79, 1, '2026-05-13 01:48:21', NULL),
(80, 1, '2026-05-13 01:53:08', NULL),
(81, 1, '2026-05-13 02:07:03', NULL),
(82, 1, '2026-05-13 02:17:09', NULL),
(83, 3, '2026-05-13 02:27:45', NULL),
(84, 1, '2026-05-13 02:41:22', NULL),
(85, 1, '2026-05-13 02:51:13', NULL),
(86, 1, '2026-05-13 03:04:26', NULL),
(87, 1, '2026-05-13 03:21:28', NULL),
(88, 1, '2026-05-13 03:28:20', NULL),
(89, 1, '2026-05-13 03:29:07', NULL),
(90, 1, '2026-05-13 03:30:02', NULL),
(91, 1, '2026-05-13 03:31:24', NULL),
(92, 1, '2026-05-13 03:34:43', NULL),
(93, 1, '2026-05-13 03:42:47', NULL),
(94, 1, '2026-05-13 03:44:13', NULL),
(95, 1, '2026-05-13 03:46:06', NULL),
(96, 1, '2026-05-13 03:51:20', NULL),
(97, 1, '2026-05-13 03:58:57', NULL),
(98, 1, '2026-05-13 04:02:47', NULL),
(99, 1, '2026-05-13 04:09:39', NULL),
(100, 1, '2026-05-13 04:18:01', NULL),
(101, 1, '2026-05-13 04:23:07', NULL),
(102, 1, '2026-05-13 04:28:24', NULL),
(103, 3, '2026-05-13 04:28:53', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `audit_trail`
--

CREATE TABLE `audit_trail` (
  `audit_id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `module` varchar(50) DEFAULT NULL,
  `action_type` varchar(50) DEFAULT NULL,
  `description` text DEFAULT NULL,
  `action_date` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `audit_trail`
--

INSERT INTO `audit_trail` (`audit_id`, `user_id`, `module`, `action_type`, `description`, `action_date`) VALUES
(1, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-12 21:17:40'),
(2, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-12 21:24:47'),
(3, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-12 21:34:25'),
(4, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-12 22:01:01'),
(5, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-12 22:01:55'),
(6, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-12 22:17:05'),
(7, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-12 22:42:48'),
(8, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-12 22:50:32'),
(9, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-12 22:58:36'),
(10, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-12 22:59:02'),
(11, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-12 23:03:20'),
(12, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-12 23:06:01'),
(13, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-12 23:17:58'),
(14, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-12 23:21:29'),
(15, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-12 23:34:28'),
(16, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-12 23:39:01'),
(17, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-12 23:40:40'),
(18, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-12 23:46:07'),
(19, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-12 23:58:00'),
(20, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 00:11:08'),
(21, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 00:15:00'),
(22, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 00:15:40'),
(23, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 00:16:25'),
(24, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 00:17:52'),
(25, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 00:19:04'),
(26, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 00:23:17'),
(27, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 00:29:25'),
(28, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 00:40:51'),
(29, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 00:48:35'),
(30, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 00:51:18'),
(31, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 00:54:48'),
(32, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 01:00:03'),
(33, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 01:10:21'),
(34, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 01:13:21'),
(35, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 01:22:13'),
(36, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 01:24:59'),
(37, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 01:27:23'),
(38, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 01:28:33'),
(39, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 01:30:31'),
(40, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 01:33:18'),
(41, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 01:36:33'),
(42, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 01:40:11'),
(43, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 01:40:55'),
(44, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 01:42:32'),
(45, NULL, 'Auth', 'Login', 'Supervisor - Barnae logged in.', '2026-05-13 01:43:04'),
(46, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 01:48:21'),
(47, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 01:53:08'),
(48, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 02:07:03'),
(49, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 02:17:09'),
(50, 3, 'Auth', 'Login', 'Supervisor - Barnae logged in.', '2026-05-13 02:27:45'),
(51, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 02:41:22'),
(52, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 02:51:13'),
(53, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 03:04:26'),
(54, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 03:21:28'),
(55, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 03:28:20'),
(56, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 03:29:07'),
(57, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 03:30:02'),
(58, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 03:31:24'),
(59, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 03:34:43'),
(60, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 03:42:47'),
(61, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 03:44:13'),
(62, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 03:46:06'),
(63, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 03:51:20'),
(64, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 03:58:57'),
(65, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 04:02:47'),
(66, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 04:09:39'),
(67, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 04:18:01'),
(68, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 04:23:07'),
(69, 1, 'Auth', 'Login', 'Admin - System Admin logged in.', '2026-05-13 04:28:24'),
(70, 3, 'Auth', 'Login', 'Supervisor - Barnae logged in.', '2026-05-13 04:28:53');

-- --------------------------------------------------------

--
-- Table structure for table `deliveries`
--

CREATE TABLE `deliveries` (
  `delivery_id` int(11) NOT NULL,
  `supplier_id` int(11) DEFAULT NULL,
  `fuel_type_id` int(11) DEFAULT NULL,
  `dr_number` varchar(50) DEFAULT NULL,
  `volume_liters` float DEFAULT NULL,
  `delivery_date` datetime DEFAULT NULL,
  `received_by` int(11) DEFAULT NULL,
  `price_per_liter` decimal(10,2) DEFAULT 0.00,
  `status` varchar(20) DEFAULT 'Pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `deliveries`
--

INSERT INTO `deliveries` (`delivery_id`, `supplier_id`, `fuel_type_id`, `dr_number`, `volume_liters`, `delivery_date`, `received_by`, `price_per_liter`, `status`) VALUES
(1, 1, 1, '23235', 5000, '2026-05-13 01:36:36', NULL, 123.00, 'Delivered'),
(2, 1, 1, '7423', 12312, '2026-05-13 02:28:09', NULL, 231.00, 'Delivered'),
(3, 1, 4, '6345134', 12342, '2026-05-13 04:03:35', NULL, 2334.00, 'Delivered');

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `employee_id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `contact_number` varchar(20) DEFAULT NULL,
  `shift` varchar(20) DEFAULT NULL,
  `avatar_initials` varchar(5) DEFAULT NULL,
  `created_at` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`employee_id`, `user_id`, `contact_number`, `shift`, `avatar_initials`, `created_at`) VALUES
(1, 1, '0000000000', 'Morning', 'SA', '2026-05-01 20:51:52'),
(3, 3, '12356678', 'Night', 'BA', '2026-05-13 02:17:47');

-- --------------------------------------------------------

--
-- Table structure for table `fuel_types`
--

CREATE TABLE `fuel_types` (
  `fuel_type_id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `current_stock_liters` float DEFAULT 0,
  `min_stock_threshold` float DEFAULT 0,
  `status` enum('Available','Low','Out of Stock') DEFAULT 'Available',
  `updated_at` datetime DEFAULT NULL,
  `price_per_liter` decimal(10,2) DEFAULT 0.00
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `fuel_types`
--

INSERT INTO `fuel_types` (`fuel_type_id`, `name`, `current_stock_liters`, `min_stock_threshold`, `status`, `updated_at`, `price_per_liter`) VALUES
(1, 'Diesel', 21512, 1000, 'Available', '2026-05-13 03:51:50', 0.00),
(2, 'RON 91', 3100, 800, 'Available', '2026-05-02 01:38:22', 0.00),
(3, 'RON 95', 670, 1000, 'Low', '2026-05-13 03:45:01', 0.00),
(4, 'Premium Diesel', 12342, 500, 'Out of Stock', '2026-05-02 01:38:22', 0.00);

-- --------------------------------------------------------

--
-- Table structure for table `pumps`
--

CREATE TABLE `pumps` (
  `pump_id` int(11) NOT NULL,
  `fuel_type_id` int(11) DEFAULT NULL,
  `pump_label` varchar(50) DEFAULT NULL,
  `status` enum('Active','Inactive','Maintenance') DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pumps`
--

INSERT INTO `pumps` (`pump_id`, `fuel_type_id`, `pump_label`, `status`) VALUES
(1, 1, 'Pump 01', 'Active'),
(2, 2, 'Pump 02', 'Active'),
(3, 3, 'Pump 03', 'Active'),
(4, 4, 'Pump 04', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `reports`
--

CREATE TABLE `reports` (
  `report_id` int(11) NOT NULL,
  `generated_by` int(11) DEFAULT NULL,
  `report_type` varchar(50) DEFAULT NULL,
  `date_range_start` date DEFAULT NULL,
  `date_range_end` date DEFAULT NULL,
  `generated_at` datetime DEFAULT current_timestamp(),
  `export_path` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `reports`
--

INSERT INTO `reports` (`report_id`, `generated_by`, `report_type`, `date_range_start`, `date_range_end`, `generated_at`, `export_path`) VALUES
(1, 1, 'Monthly Revenue Report', '2026-05-01', '2026-06-01', '2026-05-05 04:34:09', 'C:\\Users\\ASUS\\OneDrive\\Documents\\Monthly Revenue Report_20260505_043406.pdf'),
(2, 1, 'Daily Sales Summary', '2026-05-13', '2026-05-14', '2026-05-13 04:23:20', 'C:\\Users\\ASUS\\OneDrive\\Documents\\Daily Sales Summary_20260513_042317.pdf');

-- --------------------------------------------------------

--
-- Table structure for table `suppliers`
--

CREATE TABLE `suppliers` (
  `supplier_id` int(11) NOT NULL,
  `company_name` varchar(100) DEFAULT NULL,
  `contact_person` varchar(100) DEFAULT NULL,
  `contact_number` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `status` enum('Active','Inactive') DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `suppliers`
--

INSERT INTO `suppliers` (`supplier_id`, `company_name`, `contact_person`, `contact_number`, `email`, `status`) VALUES
(1, 'Bing', 'erl', '09123734', 'test@example.com', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `supplier_fuel_types`
--

CREATE TABLE `supplier_fuel_types` (
  `id` int(11) NOT NULL,
  `supplier_id` int(11) DEFAULT NULL,
  `fuel_type_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE `transactions` (
  `transaction_id` int(11) NOT NULL,
  `pump_id` int(11) DEFAULT NULL,
  `employee_id` int(11) DEFAULT NULL,
  `fuel_type_id` int(11) DEFAULT NULL,
  `liters_dispensed` float DEFAULT NULL,
  `amount_paid` decimal(10,2) DEFAULT NULL,
  `payment_method` enum('Cash','GCash','Card') DEFAULT NULL,
  `transaction_date` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`transaction_id`, `pump_id`, `employee_id`, `fuel_type_id`, `liters_dispensed`, `amount_paid`, `payment_method`, `transaction_date`) VALUES
(2, 1, NULL, 1, 0, 23.00, 'GCash', '2026-05-13 01:04:21'),
(3, 1, NULL, 1, 234, 3424.00, 'Cash', '2026-05-13 01:22:28'),
(4, 1, 1, 1, 1000, 1234.00, 'Cash', '2026-05-13 01:33:38'),
(5, 1, 3, 1, 1000, 234.00, 'Cash', '2026-05-13 02:52:54'),
(6, 3, 3, 3, 230, 123234.00, 'Card', '2026-05-13 03:45:01'),
(7, 1, 1, 1, 1000, 2344.00, 'Cash', '2026-05-13 03:51:50');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password_hash` varchar(255) NOT NULL,
  `full_name` varchar(100) DEFAULT NULL,
  `role` enum('Admin','Supervisor','Cashier') NOT NULL,
  `status` enum('Active','Inactive') DEFAULT 'Active',
  `created_at` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `password_hash`, `full_name`, `role`, `status`, `created_at`) VALUES
(1, 'admin', '3eb3fe66b31e3b4d10fa70b5cad49c7112294af6ae4e476a1c405155d45aa121', 'System Admin', 'Admin', 'Active', '2026-05-01 20:51:52'),
(3, 'barnae', 'e606e38b0d8c19b24cf0ee3808183162ea7cd63ff7912dbb22b5e803286b4446', 'Barnae', 'Supervisor', 'Active', '2026-05-13 02:17:47');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`attendance_id`),
  ADD KEY `employee_id` (`employee_id`);

--
-- Indexes for table `audit_trail`
--
ALTER TABLE `audit_trail`
  ADD PRIMARY KEY (`audit_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `deliveries`
--
ALTER TABLE `deliveries`
  ADD PRIMARY KEY (`delivery_id`),
  ADD KEY `supplier_id` (`supplier_id`),
  ADD KEY `fuel_type_id` (`fuel_type_id`),
  ADD KEY `received_by` (`received_by`);

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`employee_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `fuel_types`
--
ALTER TABLE `fuel_types`
  ADD PRIMARY KEY (`fuel_type_id`);

--
-- Indexes for table `pumps`
--
ALTER TABLE `pumps`
  ADD PRIMARY KEY (`pump_id`),
  ADD KEY `fuel_type_id` (`fuel_type_id`);

--
-- Indexes for table `reports`
--
ALTER TABLE `reports`
  ADD PRIMARY KEY (`report_id`),
  ADD KEY `generated_by` (`generated_by`);

--
-- Indexes for table `suppliers`
--
ALTER TABLE `suppliers`
  ADD PRIMARY KEY (`supplier_id`);

--
-- Indexes for table `supplier_fuel_types`
--
ALTER TABLE `supplier_fuel_types`
  ADD PRIMARY KEY (`id`),
  ADD KEY `supplier_id` (`supplier_id`),
  ADD KEY `fuel_type_id` (`fuel_type_id`);

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`transaction_id`),
  ADD KEY `pump_id` (`pump_id`),
  ADD KEY `employee_id` (`employee_id`),
  ADD KEY `fuel_type_id` (`fuel_type_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `attendance`
--
ALTER TABLE `attendance`
  MODIFY `attendance_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=104;

--
-- AUTO_INCREMENT for table `audit_trail`
--
ALTER TABLE `audit_trail`
  MODIFY `audit_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=71;

--
-- AUTO_INCREMENT for table `deliveries`
--
ALTER TABLE `deliveries`
  MODIFY `delivery_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `employee_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `fuel_types`
--
ALTER TABLE `fuel_types`
  MODIFY `fuel_type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `pumps`
--
ALTER TABLE `pumps`
  MODIFY `pump_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `reports`
--
ALTER TABLE `reports`
  MODIFY `report_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `suppliers`
--
ALTER TABLE `suppliers`
  MODIFY `supplier_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `supplier_fuel_types`
--
ALTER TABLE `supplier_fuel_types`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `transactions`
--
ALTER TABLE `transactions`
  MODIFY `transaction_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `attendance`
--
ALTER TABLE `attendance`
  ADD CONSTRAINT `attendance_ibfk_1` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`employee_id`) ON DELETE CASCADE;

--
-- Constraints for table `audit_trail`
--
ALTER TABLE `audit_trail`
  ADD CONSTRAINT `audit_trail_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE SET NULL;

--
-- Constraints for table `deliveries`
--
ALTER TABLE `deliveries`
  ADD CONSTRAINT `deliveries_ibfk_1` FOREIGN KEY (`supplier_id`) REFERENCES `suppliers` (`supplier_id`) ON DELETE SET NULL,
  ADD CONSTRAINT `deliveries_ibfk_2` FOREIGN KEY (`fuel_type_id`) REFERENCES `fuel_types` (`fuel_type_id`) ON DELETE SET NULL,
  ADD CONSTRAINT `deliveries_ibfk_3` FOREIGN KEY (`received_by`) REFERENCES `employees` (`employee_id`) ON DELETE SET NULL;

--
-- Constraints for table `employees`
--
ALTER TABLE `employees`
  ADD CONSTRAINT `employees_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE SET NULL;

--
-- Constraints for table `pumps`
--
ALTER TABLE `pumps`
  ADD CONSTRAINT `pumps_ibfk_1` FOREIGN KEY (`fuel_type_id`) REFERENCES `fuel_types` (`fuel_type_id`) ON DELETE SET NULL;

--
-- Constraints for table `reports`
--
ALTER TABLE `reports`
  ADD CONSTRAINT `reports_ibfk_1` FOREIGN KEY (`generated_by`) REFERENCES `users` (`user_id`) ON DELETE SET NULL;

--
-- Constraints for table `supplier_fuel_types`
--
ALTER TABLE `supplier_fuel_types`
  ADD CONSTRAINT `supplier_fuel_types_ibfk_1` FOREIGN KEY (`supplier_id`) REFERENCES `suppliers` (`supplier_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `supplier_fuel_types_ibfk_2` FOREIGN KEY (`fuel_type_id`) REFERENCES `fuel_types` (`fuel_type_id`) ON DELETE CASCADE;

--
-- Constraints for table `transactions`
--
ALTER TABLE `transactions`
  ADD CONSTRAINT `transactions_ibfk_1` FOREIGN KEY (`pump_id`) REFERENCES `pumps` (`pump_id`) ON DELETE SET NULL,
  ADD CONSTRAINT `transactions_ibfk_2` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`employee_id`) ON DELETE SET NULL,
  ADD CONSTRAINT `transactions_ibfk_3` FOREIGN KEY (`fuel_type_id`) REFERENCES `fuel_types` (`fuel_type_id`) ON DELETE SET NULL;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
