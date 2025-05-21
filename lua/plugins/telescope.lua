-- plugins/telescope.lua:
return {
  "nvim-telescope/telescope.nvim",
  dependencies = { "nvim-lua/plenary.nvim" },
  config = function()
    require("telescope").setup({
      defaults = {
        -- Ignore common directories
        file_ignore_patterns = { "node_modules/", "%.git/" },
        -- Ensure Telescope respects the current working directory
        vimgrep_arguments = {
          "rg",
          "--color=never",
          "--no-heading",
          "--with-filename",
          "--line-number",
          "--column",
          "--smart-case",
        },
      },
      pickers = {
        find_files = {
          -- Explicitly use fd for file searching
          find_command = { "fd", "--type", "f", "--strip-cwd-prefix" },
          -- Show hidden files (optional, adjust as needed)
          hidden = true,
        },
      },
    })
     require('telescope').setup({})

     local builtin = require('telescope.builtin')
     vim.keymap.set('n', '<leader>pf', builtin.find_files, {})
     vim.keymap.set('n', '<C-p>', builtin.git_files, {})
     vim.keymap.set('n', '<leader>pws', function()
         local word = vim.fn.expand("<cword>")
         builtin.grep_string({ search = word })
        end)
     vim.keymap.set('n', '<leader>pWs', function()
         local word = vim.fn.expand("<cWORD>")
         builtin.grep_string({ search = word })
        end)
     vim.keymap.set('n', '<leader>ps', function()
         builtin.grep_string({ search = vim.fn.input("Grep > ") })
        end)
     vim.keymap.set('n', '<leader>vh', builtin.help_tags, {})
  end,
}
