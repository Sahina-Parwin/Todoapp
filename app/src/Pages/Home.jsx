import React, { useState } from "react";
import TodoItem from "./TodoItem";

const dummyTodos = [
  {
    id: 1,
    name: "Buy groceries",
    status: false,
    createdate: new Date("2024-05-20"),
  },
  {
    id: 2,
    name: "Finish React project",
    status: true,
    createdate: new Date("2024-05-21"),
  },
  {
    id: 3,
    name: "Read a book",
    status: false,
    createdate: new Date("2024-05-22"),
  },
];

const Home = () => {
  const [todos, setTodos] = useState(dummyTodos);
  const [input, setInput] = useState("");

  const handleAdd = (e) => {
    e.preventDefault();
    if (!input.trim()) return;
    setTodos([
      ...todos,
      {
        id: Date.now(),
        name: input,
        status: false,
        createdate: new Date(),
      },
    ]);
    setInput("");
  };

  const handleToggle = (id) => {
    setTodos(
      todos.map((todo) =>
        todo.id === id ? { ...todo, status: !todo.status } : todo
      )
    );
  };

  const handleDelete = (id) => {
    setTodos(todos.filter((todo) => todo.id !== id));
  };

  const handleEdit = (id, newName) => {
    setTodos(
      todos.map((todo) =>
        todo.id === id ? { ...todo, name: newName } : todo
      )
    );
  };

  return (
    <div className="container mt-5" style={{ maxWidth: 600 }}>
      <h2 className="mb-4">Todo App</h2>
      <form className="input-group mb-3" onSubmit={handleAdd}>
        <input
          type="text"
          className="form-control"
          placeholder="Add a new todo"
          value={input}
          onChange={(e) => setInput(e.target.value)}
        />
        <button className="btn btn-primary" type="submit">
          Add
        </button>
      </form>
      <ul className="list-group">
        {todos.length === 0 && (
          <li className="list-group-item text-muted">No todos yet.</li>
        )}
        {todos.map((todo) => (
          <TodoItem
            key={todo.id}
            todo={todo}
            onToggle={handleToggle}
            onDelete={handleDelete}
            onEdit={handleEdit}
          />
        ))}
      </ul>
    </div>
  );
};

export default Home;