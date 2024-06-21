"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const express_1 = __importDefault(require("express"));
const body_parser_1 = __importDefault(require("body-parser"));
const fs_1 = __importDefault(require("fs"));
const path_1 = __importDefault(require("path"));
const app = (0, express_1.default)();
const PORT = 3000;
const dbFilePath = path_1.default.join(__dirname, 'db.json');
app.use(body_parser_1.default.json());
app.get('/ping', (req, res) => {
    res.json(true);
});
app.post('/submit', (req, res) => {
    const { name, email, phone, github_link, stopwatch_time } = req.body;
    if (!name || !email || !phone || !github_link || !stopwatch_time) {
        return res.status(400).json({ error: 'All fields are required' });
    }
    const newSubmission = { name, email, phone, github_link, stopwatch_time };
    fs_1.default.readFile(dbFilePath, 'utf8', (err, data) => {
        if (err) {
            return res.status(500).json({ error: 'Error reading database file' });
        }
        const submissions = data ? JSON.parse(data) : [];
        submissions.push(newSubmission);
        fs_1.default.writeFile(dbFilePath, JSON.stringify(submissions, null, 2), 'utf8', (err) => {
            if (err) {
                return res.status(500).json({ error: 'Error writing to database file' });
            }
            res.status(201).json(newSubmission);
        });
    });
});
app.get('/read', (req, res) => {
    const { index } = req.query;
    if (index === undefined) {
        return res.status(400).json({ error: 'Index is required' });
    }
    const idx = parseInt(index, 10);
    if (isNaN(idx) || idx < 0) {
        return res.status(400).json({ error: 'Invalid index' });
    }
    fs_1.default.readFile(dbFilePath, 'utf8', (err, data) => {
        if (err) {
            return res.status(500).json({ error: 'Error reading database file' });
        }
        const submissions = data ? JSON.parse(data) : [];
        if (idx >= submissions.length) {
            return res.status(404).json({ error: 'Submission not found' });
        }
        res.json(submissions[idx]);
    });
});
app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});
