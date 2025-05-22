import React, { useState } from "react";

const TodoItem = ({ todo, onToggle, onDelete, onEdit }) => {
  const [isEditing, setIsEditing] = useState(false);
  const [editValue, setEditValue] = useState(todo.name);

  const handleEdit = () => setIsEditing(true);

  const handleSave = () => {
    if (editValue.trim()) {
      onEdit(todo.id, editValue.trim());
      setIsEditing(false);
    }
  };

  const handleCancel = () => {
    setEditValue(todo.name);
    setIsEditing(false);
  };

  return (
    <li
      className={`list-group-item d-flex justify-content-between align-items-center ${
        todo.status ? "list-group-item-success" : ""
      }`}
    >
      <span
        style={{
          textDecoration: todo.status ? "line-through" : "none",
          cursor: isEditing ? "default" : "pointer",
          flex: 1,
        }}
        onClick={() => !isEditing && onToggle(todo.id)}
      >
        {isEditing ? (
          <input
            type="text"
            className="form-control"
            value={editValue}
            onChange={(e) => setEditValue(e.target.value)}
            onKeyDown={(e) => {
              if (e.key === "Enter") handleSave();
              if (e.key === "Escape") handleCancel();
            }}
            autoFocus
            style={{ maxWidth: 200, display: "inline-block" }}
          />
        ) : (
          todo.name
        )}
      </span>
      {isEditing ? (
        <>
          <button className="btn btn-sm btn-success ms-2" onClick={handleSave}>
            Save
          </button>
          <button className="btn btn-sm btn-secondary ms-2" onClick={handleCancel}>
            Cancel
          </button>
        </>
      ) : (
        <>
          <button className="btn btn-sm btn-warning ms-2" onClick={handleEdit}>
            Edit
          </button>
          <button
            className="btn btn-sm btn-danger ms-2"
            onClick={() => onDelete(todo.id)}
          >
            Delete
          </button>
        </>
      )}
    </li>
  );
};

export default TodoItem;