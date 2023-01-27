namespace CoreWolf
{
    public static class BuiltinFunctionT
    {
        ///<summary>
        ///generates a list of n copies of expr.
        ///https://reference.wolfram.com/language/ref/Table.html
        ///</summary>
        public static Engine Table(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Table[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a list of the values of expr when i runs from 1 to imax.
        ///https://reference.wolfram.com/language/ref/Table.html
        ///</summary>
        public static Engine Table(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Table[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses the successive values i1, i2, ….
        ///https://reference.wolfram.com/language/ref/Table.html
        ///</summary>
        public static Engine Table(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Table[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives a nested list. The list associated with i is outermost. »
        ///https://reference.wolfram.com/language/ref/Table.html
        ///</summary>
        public static Engine Table(this Engine en, object arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("Table[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///prints with the elements of list arranged in an array of rectangular cells.
        ///https://reference.wolfram.com/language/ref/TableForm.html
        ///</summary>
        public static Engine TableForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TableForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as a spreadsheet-like table view for editing and viewing exprij.
        ///https://reference.wolfram.com/language/ref/TableView.html
        ///</summary>
        public static Engine TableView(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TableView[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///takes the contents of the table view to be the dynamically updated current value of x, with the value of x being reset as the table view is interactively edited.
        ///https://reference.wolfram.com/language/ref/TableView.html
        ///</summary>
        public static Engine TableView(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TableView[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses the specified type by default to represent newly edited or created entries in the table view.
        ///https://reference.wolfram.com/language/ref/TableView.html
        ///</summary>
        public static Engine TableView(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TableView[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays an empty table view.
        ///https://reference.wolfram.com/language/ref/TableView.html
        ///</summary>
        public static Engine TableView(this Engine en, string? name = null)
        {
            return en.Execute("TableView[]", name);
        }

        ///<summary>
        ///represents an object in which clicking the tab with label lbli displays expri.
        ///https://reference.wolfram.com/language/ref/TabView.html
        ///</summary>
        public static Engine TabView(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TabView[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///makes the i tab be the one currently selected.
        ///https://reference.wolfram.com/language/ref/TabView.html
        ///</summary>
        public static Engine TabView(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("TabView[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///associates values vi with successive tabs, and makes the tab with value v be the one currently selected.
        ///https://reference.wolfram.com/language/ref/TabView.html
        ///</summary>
        public static Engine TabView(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("TabView[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is a low-level box construct that displays as boxes but maintains tag to guide the interpretation of boxes on input.
        ///https://reference.wolfram.com/language/ref/TagBox.html
        ///</summary>
        public static Engine TagBox(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TagBox[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the first n elements of list.
        ///https://reference.wolfram.com/language/ref/Take.html
        ///</summary>
        public static Engine Take(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Take[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives elements m through n of list.
        ///https://reference.wolfram.com/language/ref/Take.html
        ///</summary>
        public static Engine Take(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Take[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a nested list in which elements specified by seqi are taken at level i in list.
        ///https://reference.wolfram.com/language/ref/Take.html
        ///</summary>
        public static Engine Take(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("Take[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the pair {list1,list2}, where list1 contains the first n elements of list and list2 contains the rest.
        ///https://reference.wolfram.com/language/ref/TakeDrop.html
        ///</summary>
        public static Engine TakeDrop(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TakeDrop[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the n numerically largest elements in list, sorted in descending order.
        ///https://reference.wolfram.com/language/ref/TakeLargest.html
        ///</summary>
        public static Engine TakeLargest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TakeLargest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of TakeLargest that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/TakeLargest.html
        ///</summary>
        public static Engine TakeLargest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TakeLargest[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the n elements ei in list for which f[ei] is largest, sorted in descending order.
        ///https://reference.wolfram.com/language/ref/TakeLargestBy.html
        ///</summary>
        public static Engine TakeLargestBy(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TakeLargestBy[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of TakeLargestBy that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/TakeLargestBy.html
        ///</summary>
        public static Engine TakeLargestBy(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TakeLargestBy[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the list of results obtained by successively taking ni elements from list.
        ///https://reference.wolfram.com/language/ref/TakeList.html
        ///</summary>
        public static Engine TakeList(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TakeList[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a nested list in which elements specified by the lists seqsi are taken at level i in list.
        ///https://reference.wolfram.com/language/ref/TakeList.html
        ///</summary>
        public static Engine TakeList(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("TakeList[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the n numerically smallest elements in list, sorted in ascending order.
        ///https://reference.wolfram.com/language/ref/TakeSmallest.html
        ///</summary>
        public static Engine TakeSmallest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TakeSmallest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of TakeSmallest that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/TakeSmallest.html
        ///</summary>
        public static Engine TakeSmallest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TakeSmallest[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the n elements ei in list for which f[ei] is smallest, sorted in ascending order.
        ///https://reference.wolfram.com/language/ref/TakeSmallestBy.html
        ///</summary>
        public static Engine TakeSmallestBy(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TakeSmallestBy[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of TakeSmallestBy that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/TakeSmallestBy.html
        ///</summary>
        public static Engine TakeSmallestBy(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TakeSmallestBy[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives elements ei from the beginning of list, continuing so long as crit[ei] is True.
        ///https://reference.wolfram.com/language/ref/TakeWhile.html
        ///</summary>
        public static Engine TakeWhile(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TakeWhile[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tallies the elements in list, listing all distinct elements together with their multiplicities.
        ///https://reference.wolfram.com/language/ref/Tally.html
        ///</summary>
        public static Engine Tally(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Tally[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses test to determine whether pairs of elements should be considered equivalent, and gives a list of the first representatives of each equivalence class, together with their multiplicities.
        ///https://reference.wolfram.com/language/ref/Tally.html
        ///</summary>
        public static Engine Tally(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Tally[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the tangent of .
        ///https://reference.wolfram.com/language/ref/Tan.html
        ///</summary>
        public static Engine Tan(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Tan[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the hyperbolic tangent of .
        ///https://reference.wolfram.com/language/ref/Tanh.html
        ///</summary>
        public static Engine Tanh(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Tanh[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates an interrupt to abort the current execution of a task.
        ///https://reference.wolfram.com/language/ref/TaskAbort.html
        ///</summary>
        public static Engine TaskAbort(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TaskAbort[" + arg0 + "]", name);
        }

        ///<summary>
        ///immediately executes an instance of the specified task, independently of any schedule given.
        ///https://reference.wolfram.com/language/ref/TaskExecute.html
        ///</summary>
        public static Engine TaskExecute(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TaskExecute[" + arg0 + "]", name);
        }

        ///<summary>
        ///is an object that represents a background task.
        ///https://reference.wolfram.com/language/ref/TaskObject.html
        ///</summary>
        public static Engine TaskObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TaskObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///terminates and removes the specified task.
        ///https://reference.wolfram.com/language/ref/TaskRemove.html
        ///</summary>
        public static Engine TaskRemove(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TaskRemove[" + arg0 + "]", name);
        }

        ///<summary>
        ///resumes execution of the specified task.
        ///https://reference.wolfram.com/language/ref/TaskResume.html
        ///</summary>
        public static Engine TaskResume(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TaskResume[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of TaskObject expressions representing currently submitted tasks of given type.
        ///https://reference.wolfram.com/language/ref/Tasks.html
        ///</summary>
        public static Engine Tasks(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Tasks[" + arg0 + "]", name);
        }

        ///<summary>
        ///suspends the execution of the specified task.
        ///https://reference.wolfram.com/language/ref/TaskSuspend.html
        ///</summary>
        public static Engine TaskSuspend(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TaskSuspend[" + arg0 + "]", name);
        }

        ///<summary>
        ///waits for the specified task to be completely finished.
        ///https://reference.wolfram.com/language/ref/TaskWait.html
        ///</summary>
        public static Engine TaskWait(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TaskWait[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if all combinations of values of variables make the Boolean function bf yield True.
        ///https://reference.wolfram.com/language/ref/TautologyQ.html
        ///</summary>
        public static Engine TautologyQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TautologyQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if all combinations of values of the ai make the Boolean expression expr yield True.
        ///https://reference.wolfram.com/language/ref/TautologyQ.html
        ///</summary>
        public static Engine TautologyQ(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TautologyQ[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a telegraph process with rate μ.
        ///https://reference.wolfram.com/language/ref/TelegraphProcess.html
        ///</summary>
        public static Engine TelegraphProcess(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TelegraphProcess[" + arg0 + "]", name);
        }

        ///<summary>
        ///applies a template, evaluating all template elements it contains.
        ///https://reference.wolfram.com/language/ref/TemplateApply.html
        ///</summary>
        public static Engine TemplateApply(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TemplateApply[" + arg0 + "]", name);
        }

        ///<summary>
        ///applies a template, using args to fill slots in the template.
        ///https://reference.wolfram.com/language/ref/TemplateApply.html
        ///</summary>
        public static Engine TemplateApply(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TemplateApply[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a low-level box structure that parameterizes the display and evaluation of the boxes boxi.
        ///https://reference.wolfram.com/language/ref/TemplateBox.html
        ///</summary>
        public static Engine TemplateBox(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("TemplateBox[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///allows the use of arbitrary expressions that may or may not be boxes.
        ///https://reference.wolfram.com/language/ref/TemplateBox.html
        ///</summary>
        public static Engine TemplateBox(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("TemplateBox[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents an expression held until a template is applied, and then evaluated.
        ///https://reference.wolfram.com/language/ref/TemplateExpression.html
        ///</summary>
        public static Engine TemplateExpression(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TemplateExpression[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an element of a template object that inserts tclause if the condition evaluates to True.
        ///https://reference.wolfram.com/language/ref/TemplateIf.html
        ///</summary>
        public static Engine TemplateIf(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TemplateIf[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///inserts fclause if the condition does not evaluate to True.
        ///https://reference.wolfram.com/language/ref/TemplateIf.html
        ///</summary>
        public static Engine TemplateIf(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TemplateIf[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a template object to be applied using functions like TemplateApply.
        ///https://reference.wolfram.com/language/ref/TemplateObject.html
        ///</summary>
        public static Engine TemplateObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TemplateObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields a TemplateObject with arguments, suitable for cloud deployment or other evaluation.
        ///https://reference.wolfram.com/language/ref/TemplateObject.html
        ///</summary>
        public static Engine TemplateObject(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TemplateObject[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an element of a template object that yields a sequence consisting of body applied to each element in list.
        ///https://reference.wolfram.com/language/ref/TemplateSequence.html
        ///</summary>
        public static Engine TemplateSequence(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TemplateSequence[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a template slot to be filled from the n argument when the template is applied.
        ///https://reference.wolfram.com/language/ref/TemplateSlot.html
        ///</summary>
        public static Engine TemplateSlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TemplateSlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an element of a template object that evaluates expr after replacing TemplateSlot["name"] with value.
        ///https://reference.wolfram.com/language/ref/TemplateWith.html
        ///</summary>
        public static Engine TemplateWith(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TemplateWith[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///evaluates expr with a list of key-value pairs.
        ///https://reference.wolfram.com/language/ref/TemplateWith.html
        ///</summary>
        public static Engine TemplateWith(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("TemplateWith[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents temporal data with values vi at times specified by tspec.
        ///https://reference.wolfram.com/language/ref/TemporalData.html
        ///</summary>
        public static Engine TemporalData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("TemporalData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a temporal data collection with values vij at times specified by tspec.
        ///https://reference.wolfram.com/language/ref/TemporalData.html
        ///</summary>
        public static Engine TemporalData(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("TemporalData[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents temporal data specified by time-value pairs {ti,vi}.
        ///https://reference.wolfram.com/language/ref/TemporalData.html
        ///</summary>
        public static Engine TemporalData(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TemporalData[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a temporal data collection given as lists of time-value pairs {tij,vij}.
        ///https://reference.wolfram.com/language/ref/TemporalData.html
        ///</summary>
        public static Engine TemporalData(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("TemporalData[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///yields the contraction of tensor in the pairs {si1,si2} of slots.
        ///https://reference.wolfram.com/language/ref/TensorContract.html
        ///</summary>
        public static Engine TensorContract(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("TensorContract[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the list of dimensions of tensor.
        ///https://reference.wolfram.com/language/ref/TensorDimensions.html
        ///</summary>
        public static Engine TensorDimensions(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TensorDimensions[" + arg0 + "]", name);
        }

        ///<summary>
        ///expands out tensor-related products in the symbolic tensor expression texpr.
        ///https://reference.wolfram.com/language/ref/TensorExpand.html
        ///</summary>
        public static Engine TensorExpand(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TensorExpand[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the tensor product of the tensori.
        ///https://reference.wolfram.com/language/ref/TensorProduct.html
        ///</summary>
        public static Engine TensorProduct(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TensorProduct[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the rank of tensor.
        ///https://reference.wolfram.com/language/ref/TensorRank.html
        ///</summary>
        public static Engine TensorRank(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TensorRank[" + arg0 + "]", name);
        }

        ///<summary>
        ///attempts to return a canonical form for the symbolic tensor expression texpr.
        ///https://reference.wolfram.com/language/ref/TensorReduce.html
        ///</summary>
        public static Engine TensorReduce(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TensorReduce[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the symmetry of tensor under permutations of its slots.
        ///https://reference.wolfram.com/language/ref/TensorSymmetry.html
        ///</summary>
        public static Engine TensorSymmetry(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TensorSymmetry[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the symmetry under permutation of the specified list of slots.
        ///https://reference.wolfram.com/language/ref/TensorSymmetry.html
        ///</summary>
        public static Engine TensorSymmetry(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TensorSymmetry[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the tensor obtained by transposing the slots of tensor as given by the permutation perm.
        ///https://reference.wolfram.com/language/ref/TensorTranspose.html
        ///</summary>
        public static Engine TensorTranspose(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TensorTranspose[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the antisymmetrized tensor product of the tensori.
        ///https://reference.wolfram.com/language/ref/TensorWedge.html
        ///</summary>
        public static Engine TensorWedge(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TensorWedge[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///plots a list of points with specified u, v and w coordinates in a barycentric coordinate system.
        ///https://reference.wolfram.com/language/ref/TernaryListPlot.html
        ///</summary>
        public static Engine TernaryListPlot(this Engine en, List<object> arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("TernaryListPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///plots a ternary plot with several datasets datai.
        ///https://reference.wolfram.com/language/ref/TernaryListPlot.html
        ///</summary>
        public static Engine TernaryListPlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TernaryListPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///runs tests from a file, returning an analysis of the completed test run.
        ///https://reference.wolfram.com/language/ref/TestReport.html
        ///</summary>
        public static Engine TestReport(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TestReport[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a report of the results of the tests testi.
        ///https://reference.wolfram.com/language/ref/TestReport.html
        ///</summary>
        public static Engine TestReport(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TestReport[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives an object that represents the results of a VerificationTest.
        ///https://reference.wolfram.com/language/ref/TestResultObject.html
        ///</summary>
        public static Engine TestResultObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TestResultObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a regular tetrahedron centered at the origin with unit edge length.
        ///https://reference.wolfram.com/language/ref/Tetrahedron.html
        ///</summary>
        public static Engine Tetrahedron(this Engine en, string? name = null)
        {
            return en.Execute("Tetrahedron[]", name);
        }

        ///<summary>
        ///represents a tetrahedron with edge length l.
        ///https://reference.wolfram.com/language/ref/Tetrahedron.html
        ///</summary>
        public static Engine Tetrahedron(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Tetrahedron[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a tetrahedron rotated by an angle θ with respect to the z axis and angle ϕ with respect to the y axis.
        ///https://reference.wolfram.com/language/ref/Tetrahedron.html
        ///</summary>
        public static Engine Tetrahedron(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Tetrahedron[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a general filled tetrahedron with corners p1, p2, p3 and p4.
        ///https://reference.wolfram.com/language/ref/Tetrahedron.html
        ///</summary>
        public static Engine Tetrahedron(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Tetrahedron[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a collection of tetrahedra.
        ///https://reference.wolfram.com/language/ref/Tetrahedron.html
        ///</summary>
        public static Engine Tetrahedron(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Tetrahedron[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///prints as a  version of expr.
        ///https://reference.wolfram.com/language/ref/TeXForm.html
        ///</summary>
        public static Engine TeXForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TeXForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays with expr in plain text format.
        ///https://reference.wolfram.com/language/ref/Text.html
        ///</summary>
        public static Engine Text(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Text[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a graphics primitive that displays the textual form of expr centered at the point specified by coords.
        ///https://reference.wolfram.com/language/ref/Text.html
        ///</summary>
        public static Engine Text(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Text[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of all cases of text identified as being of type form that appear in text.
        ///https://reference.wolfram.com/language/ref/TextCases.html
        ///</summary>
        public static Engine TextCases(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TextCases[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives an association of results for all the types formi.
        ///https://reference.wolfram.com/language/ref/TextCases.html
        ///</summary>
        public static Engine TextCases(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TextCases[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the first n cases found.
        ///https://reference.wolfram.com/language/ref/TextCases.html
        ///</summary>
        public static Engine TextCases(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TextCases[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a text cell that can appear in a Wolfram System notebook.
        ///https://reference.wolfram.com/language/ref/TextCell.html
        ///</summary>
        public static Engine TextCell(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TextCell[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a text cell with the specified style.
        ///https://reference.wolfram.com/language/ref/TextCell.html
        ///</summary>
        public static Engine TextCell(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TextCell[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a text cell with multiple styles applied to it.
        ///https://reference.wolfram.com/language/ref/TextCell.html
        ///</summary>
        public static Engine TextCell(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("TextCell[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives a dataset of information about entities, dates, quantities and other content-related elements found in text.
        ///https://reference.wolfram.com/language/ref/TextContents.html
        ///</summary>
        public static Engine TextContents(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TextContents[" + arg0 + "]", name);
        }

        ///<summary>
        ///searches for cases of the type form.
        ///https://reference.wolfram.com/language/ref/TextContents.html
        ///</summary>
        public static Engine TextContents(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TextContents[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///searches for cases of types form1, form2, …
        ///https://reference.wolfram.com/language/ref/TextContents.html
        ///</summary>
        public static Engine TextContents(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TextContents[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///includes the property props for each object in the dataset produced.
        ///https://reference.wolfram.com/language/ref/TextContents.html
        ///</summary>
        public static Engine TextContents(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TextContents[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is a low-level representation of the contents of a textual cell.
        ///https://reference.wolfram.com/language/ref/TextData.html
        ///</summary>
        public static Engine TextData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TextData[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an element of text with the specified properties.
        ///https://reference.wolfram.com/language/ref/TextElement.html
        ///</summary>
        public static Engine TextElement(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TextElement[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents text formed from a sequence of elements.
        ///https://reference.wolfram.com/language/ref/TextElement.html
        ///</summary>
        public static Engine TextElement(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("TextElement[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents text where no properties are specified.
        ///https://reference.wolfram.com/language/ref/TextElement.html
        ///</summary>
        public static Engine TextElement(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TextElement[" + arg0 + "]", name);
        }

        ///<summary>
        ///is an object that formats exprij textually and arranged in a two-dimensional grid.
        ///https://reference.wolfram.com/language/ref/TextGrid.html
        ///</summary>
        public static Engine TextGrid(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TextGrid[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///is a WSTP packet containing string, the text output from the Wolfram System as produced by functions such as Print.
        ///https://reference.wolfram.com/language/ref/TextPacket.html
        ///</summary>
        public static Engine TextPacket(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TextPacket[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of the starting and ending positions at which instances of form occur in text.
        ///https://reference.wolfram.com/language/ref/TextPosition.html
        ///</summary>
        public static Engine TextPosition(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TextPosition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives an association of results for all the types formi.
        ///https://reference.wolfram.com/language/ref/TextPosition.html
        ///</summary>
        public static Engine TextPosition(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TextPosition[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the positions of the first n cases found.
        ///https://reference.wolfram.com/language/ref/TextPosition.html
        ///</summary>
        public static Engine TextPosition(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TextPosition[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///recognizes text in image and returns it as a string.
        ///https://reference.wolfram.com/language/ref/TextRecognize.html
        ///</summary>
        public static Engine TextRecognize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TextRecognize[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a list of strings at the specified structural level.
        ///https://reference.wolfram.com/language/ref/TextRecognize.html
        ///</summary>
        public static Engine TextRecognize(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TextRecognize[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns prop for text at the given level.
        ///https://reference.wolfram.com/language/ref/TextRecognize.html
        ///</summary>
        public static Engine TextRecognize(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TextRecognize[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///searches for files referenced by source that contain text matching form.
        ///https://reference.wolfram.com/language/ref/TextSearch.html
        ///</summary>
        public static Engine TextSearch(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TextSearch[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the property prop for each result.
        ///https://reference.wolfram.com/language/ref/TextSearch.html
        ///</summary>
        public static Engine TextSearch(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TextSearch[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a structured report of files referenced by source that contain text matching form.
        ///https://reference.wolfram.com/language/ref/TextSearchReport.html
        ///</summary>
        public static Engine TextSearchReport(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TextSearchReport[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the runs of characters identified as sentences in string.
        ///https://reference.wolfram.com/language/ref/TextSentences.html
        ///</summary>
        public static Engine TextSentences(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TextSentences[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the first n sentences in string.
        ///https://reference.wolfram.com/language/ref/TextSentences.html
        ///</summary>
        public static Engine TextSentences(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TextSentences[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a human-readable string representation of expr.
        ///https://reference.wolfram.com/language/ref/TextString.html
        ///</summary>
        public static Engine TextString(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TextString[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a nested collection of TextElement objects representing the grammatical structure of natural language text.
        ///https://reference.wolfram.com/language/ref/TextStructure.html
        ///</summary>
        public static Engine TextStructure(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TextStructure[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a representation of the type specified by form of the grammatical structure of text.
        ///https://reference.wolfram.com/language/ref/TextStructure.html
        ///</summary>
        public static Engine TextStructure(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TextStructure[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///translates text into the current default language.
        ///https://reference.wolfram.com/language/ref/TextTranslation.html
        ///</summary>
        public static Engine TextTranslation(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TextTranslation[" + arg0 + "]", name);
        }

        ///<summary>
        ///translates text into the language specified by lang.
        ///https://reference.wolfram.com/language/ref/TextTranslation.html
        ///</summary>
        public static Engine TextTranslation(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TextTranslation[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a graphics directive that specifies that obj should be used as a texture on faces of polygons and other filled graphics objects.
        ///https://reference.wolfram.com/language/ref/Texture.html
        ///</summary>
        public static Engine Texture(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Texture[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of the runs of characters identified as words in string.
        ///https://reference.wolfram.com/language/ref/TextWords.html
        ///</summary>
        public static Engine TextWords(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TextWords[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the first n words in string.
        ///https://reference.wolfram.com/language/ref/TextWords.html
        ///</summary>
        public static Engine TextWords(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TextWords[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/Therefore.html
        ///</summary>
        public static Engine Therefore(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Therefore[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specific property for the substance "name".
        ///https://reference.wolfram.com/language/ref/ThermodynamicData.html
        ///</summary>
        public static Engine ThermodynamicData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ThermodynamicData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specific property for the substance "name" at the specified parameters.
        ///https://reference.wolfram.com/language/ref/ThermodynamicData.html
        ///</summary>
        public static Engine ThermodynamicData(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ThermodynamicData[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///draws a thermometer showing value in a range of 0 to 1.
        ///https://reference.wolfram.com/language/ref/ThermometerGauge.html
        ///</summary>
        public static Engine ThermometerGauge(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ThermometerGauge[" + arg0 + "]", name);
        }

        ///<summary>
        ///draws a thermometer showing value in a range of min to max.
        ///https://reference.wolfram.com/language/ref/ThermometerGauge.html
        ///</summary>
        public static Engine ThermometerGauge(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ThermometerGauge[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///allows value to be set interactively using the thermometer.
        ///https://reference.wolfram.com/language/ref/ThermometerGauge.html
        ///</summary>
        public static Engine ThermometerGauge(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ThermometerGauge[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a graphics directive which specifies that lines which follow are to be drawn with thickness r. The thickness r is given as a fraction of the horizontal plot range.
        ///https://reference.wolfram.com/language/ref/Thickness.html
        ///</summary>
        public static Engine Thickness(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Thickness[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds the skeletons of foreground regions in image by applying morphological thinning until convergence.
        ///https://reference.wolfram.com/language/ref/Thinning.html
        ///</summary>
        public static Engine Thinning(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Thinning[" + arg0 + "]", name);
        }

        ///<summary>
        ///performs n iterations of morphological thinning.
        ///https://reference.wolfram.com/language/ref/Thinning.html
        ///</summary>
        public static Engine Thinning(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Thinning[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///treats values above t as foreground.
        ///https://reference.wolfram.com/language/ref/Thinning.html
        ///</summary>
        public static Engine Thinning(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Thinning[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a Thomas cluster point process with density μ, cluster mean λ and scale parameter σ in .
        ///https://reference.wolfram.com/language/ref/ThomasPointProcess.html
        ///</summary>
        public static Engine ThomasPointProcess(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("ThomasPointProcess[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents the sporadic simple Thompson group .
        ///https://reference.wolfram.com/language/ref/ThompsonGroupTh.html
        ///</summary>
        public static Engine ThompsonGroupTh(this Engine en, string? name = null)
        {
            return en.Execute("ThompsonGroupTh[]", name);
        }

        ///<summary>
        ///"threads" f over any lists that appear in args.
        ///https://reference.wolfram.com/language/ref/Thread.html
        ///</summary>
        public static Engine Thread(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Thread[" + arg0 + "]", name);
        }

        ///<summary>
        ///threads f over any objects with head h that appear in args.
        ///https://reference.wolfram.com/language/ref/Thread.html
        ///</summary>
        public static Engine Thread(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Thread[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///threads f over objects with head h that appear in the first n args.
        ///https://reference.wolfram.com/language/ref/Thread.html
        ///</summary>
        public static Engine Thread(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Thread[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is an object whose elements will automatically be threaded into the lowest level of an array when used in a listable operation such as Plus.
        ///https://reference.wolfram.com/language/ref/Threaded.html
        ///</summary>
        public static Engine Threaded(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Threaded[" + arg0 + "]", name);
        }

        ///<summary>
        ///adds elements at level alev of a.
        ///https://reference.wolfram.com/language/ref/Threaded.html
        ///</summary>
        public static Engine Threaded(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Threaded[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a net layer that takes several input arrays and applies a function f to corresponding array elements.
        ///https://reference.wolfram.com/language/ref/ThreadingLayer.html
        ///</summary>
        public static Engine ThreadingLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ThreadingLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///allows array shapes to be conformed according to broadcasting specification bspec.
        ///https://reference.wolfram.com/language/ref/ThreadingLayer.html
        ///</summary>
        public static Engine ThreadingLayer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ThreadingLayer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the values of the Wigner 3‐ symbol.
        ///https://reference.wolfram.com/language/ref/ThreeJSymbol.html
        ///</summary>
        public static Engine ThreeJSymbol(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ThreeJSymbol[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///thresholds data by replacing values close to zero by zero.
        ///https://reference.wolfram.com/language/ref/Threshold.html
        ///</summary>
        public static Engine Threshold(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Threshold[" + arg0 + "]", name);
        }

        ///<summary>
        ///thresholds data using threshold specification tspec.
        ///https://reference.wolfram.com/language/ref/Threshold.html
        ///</summary>
        public static Engine Threshold(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Threshold[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives p[f1[x],f2[x]].
        ///https://reference.wolfram.com/language/ref/Through.html
        ///</summary>
        public static Engine Through(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Through[" + arg0 + "]", name);
        }

        ///<summary>
        ///performs the transformation wherever h occurs in the head of expr.
        ///https://reference.wolfram.com/language/ref/Through.html
        ///</summary>
        public static Engine Through(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Through[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///stops evaluation and returns value as the value of the nearest enclosing Catch.
        ///https://reference.wolfram.com/language/ref/Throw.html
        ///</summary>
        public static Engine Throw(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Throw[" + arg0 + "]", name);
        }

        ///<summary>
        ///is caught only by Catch[expr,form], where tag matches form.
        ///https://reference.wolfram.com/language/ref/Throw.html
        ///</summary>
        public static Engine Throw(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Throw[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns f[value,tag] as the top-level value if no appropriate Catch is found.
        ///https://reference.wolfram.com/language/ref/Throw.html
        ///</summary>
        public static Engine Throw(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Throw[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the n term in the Thue–Morse sequence.
        ///https://reference.wolfram.com/language/ref/ThueMorse.html
        ///</summary>
        public static Engine ThueMorse(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ThueMorse[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a thumbnail version of an image.
        ///https://reference.wolfram.com/language/ref/Thumbnail.html
        ///</summary>
        public static Engine Thumbnail(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Thumbnail[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a thumbnail with the specified maximum pixel size.
        ///https://reference.wolfram.com/language/ref/Thumbnail.html
        ///</summary>
        public static Engine Thumbnail(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Thumbnail[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the tidal properties for a location or a set of tidal parameters.
        ///https://reference.wolfram.com/language/ref/TideData.html
        ///</summary>
        public static Engine TideData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TideData[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the specified property for the location or tidal parameters indicated.
        ///https://reference.wolfram.com/language/ref/TideData.html
        ///</summary>
        public static Engine TideData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TideData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the value of a specified property for a date or set of dates.
        ///https://reference.wolfram.com/language/ref/TideData.html
        ///</summary>
        public static Engine TideData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TideData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/Tilde.html
        ///</summary>
        public static Engine Tilde(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Tilde[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/TildeEqual.html
        ///</summary>
        public static Engine TildeEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TildeEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/TildeFullEqual.html
        ///</summary>
        public static Engine TildeFullEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TildeFullEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/TildeTilde.html
        ///</summary>
        public static Engine TildeTilde(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TildeTilde[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///evaluates expr, stopping after t seconds.
        ///https://reference.wolfram.com/language/ref/TimeConstrained.html
        ///</summary>
        public static Engine TimeConstrained(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TimeConstrained[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns failexpr if the time constraint is not met.
        ///https://reference.wolfram.com/language/ref/TimeConstrained.html
        ///</summary>
        public static Engine TimeConstrained(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TimeConstrained[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///makes a timeline plot with dates date1, date2, ….
        ///https://reference.wolfram.com/language/ref/TimelinePlot.html
        ///</summary>
        public static Engine TimelinePlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TimelinePlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents the current time.
        ///https://reference.wolfram.com/language/ref/TimeObject.html
        ///</summary>
        public static Engine TimeObject(this Engine en, string? name = null)
        {
            return en.Execute("TimeObject[]", name);
        }

        ///<summary>
        ///represents a time object of standard normalized form.
        ///https://reference.wolfram.com/language/ref/TimeObject.html
        ///</summary>
        public static Engine TimeObject(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TimeObject[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the time component of the specified date representation.
        ///https://reference.wolfram.com/language/ref/TimeObject.html
        ///</summary>
        public static Engine TimeObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TimeObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the time object of granularity gran that includes the reference time rtime.
        ///https://reference.wolfram.com/language/ref/TimeObject.html
        ///</summary>
        public static Engine TimeObject(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TimeObject[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives True if expr is a TimeObject with valid arguments, and False otherwise.
        ///https://reference.wolfram.com/language/ref/TimeObjectQ.html
        ///</summary>
        public static Engine TimeObjectQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TimeObjectQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the number of seconds remaining until the earliest enclosing TimeConstrained will request the current computation to stop.
        ///https://reference.wolfram.com/language/ref/TimeRemaining.html
        ///</summary>
        public static Engine TimeRemaining(this Engine en, string? name = null)
        {
            return en.Execute("TimeRemaining[]", name);
        }

        ///<summary>
        ///represents a time series specified by time-value pairs {ti,vi}.
        ///https://reference.wolfram.com/language/ref/TimeSeries.html
        ///</summary>
        public static Engine TimeSeries(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TimeSeries[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a time series with values vi at times specified by tspec.
        ///https://reference.wolfram.com/language/ref/TimeSeries.html
        ///</summary>
        public static Engine TimeSeries(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("TimeSeries[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///computes the mean value of tseries over non-overlapping windows of width dt.
        ///https://reference.wolfram.com/language/ref/TimeSeriesAggregate.html
        ///</summary>
        public static Engine TimeSeriesAggregate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TimeSeriesAggregate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies the function f to the values of tseries in non-overlapping windows of width dt.
        ///https://reference.wolfram.com/language/ref/TimeSeriesAggregate.html
        ///</summary>
        public static Engine TimeSeriesAggregate(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TimeSeriesAggregate[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the k-step-ahead forecast beyond data according to the time series process tproc.
        ///https://reference.wolfram.com/language/ref/TimeSeriesForecast.html
        ///</summary>
        public static Engine TimeSeriesForecast(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TimeSeriesForecast[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the k-step-ahead forecast for TimeSeriesModel tsmod.
        ///https://reference.wolfram.com/language/ref/TimeSeriesForecast.html
        ///</summary>
        public static Engine TimeSeriesForecast(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TimeSeriesForecast[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///inserts a value v at time t in the time series tseries.
        ///https://reference.wolfram.com/language/ref/TimeSeriesInsert.html
        ///</summary>
        public static Engine TimeSeriesInsert(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TimeSeriesInsert[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///inserts the time-value pairs from tseries2 into tseries1.
        ///https://reference.wolfram.com/language/ref/TimeSeriesInsert.html
        ///</summary>
        public static Engine TimeSeriesInsert(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TimeSeriesInsert[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives conditions for the time series process tproc to be invertible.
        ///https://reference.wolfram.com/language/ref/TimeSeriesInvertibility.html
        ///</summary>
        public static Engine TimeSeriesInvertibility(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TimeSeriesInvertibility[" + arg0 + "]", name);
        }

        ///<summary>
        ///applies f to the values in tseries.
        ///https://reference.wolfram.com/language/ref/TimeSeriesMap.html
        ///</summary>
        public static Engine TimeSeriesMap(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TimeSeriesMap[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives {{t1,f[t1,x1]},{t2,f[t2,x2]},…} for the time series tseries.
        ///https://reference.wolfram.com/language/ref/TimeSeriesMapThread.html
        ///</summary>
        public static Engine TimeSeriesMapThread(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TimeSeriesMapThread[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives {{t1,f[t1,x1,a1,b1,…]},{t2,f[t2,x2,a2,b2,…]},…} for the time series tseries.
        ///https://reference.wolfram.com/language/ref/TimeSeriesMapThread.html
        ///</summary>
        public static Engine TimeSeriesMapThread(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("TimeSeriesMapThread[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///represents the symbolic time series model obtained from TimeSeriesModelFit.
        ///https://reference.wolfram.com/language/ref/TimeSeriesModel.html
        ///</summary>
        public static Engine TimeSeriesModel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TimeSeriesModel[" + arg0 + "]", name);
        }

        ///<summary>
        ///constructs a time series model for data from an automatically selected model family.
        ///https://reference.wolfram.com/language/ref/TimeSeriesModelFit.html
        ///</summary>
        public static Engine TimeSeriesModelFit(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TimeSeriesModelFit[" + arg0 + "]", name);
        }

        ///<summary>
        ///constructs a time series model for data from a model family specified by mspec.
        ///https://reference.wolfram.com/language/ref/TimeSeriesModelFit.html
        ///</summary>
        public static Engine TimeSeriesModelFit(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TimeSeriesModelFit[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uniformly resamples tseries according to its minimum time increment.
        ///https://reference.wolfram.com/language/ref/TimeSeriesResample.html
        ///</summary>
        public static Engine TimeSeriesResample(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TimeSeriesResample[" + arg0 + "]", name);
        }

        ///<summary>
        ///resamples tseries according to rspec.
        ///https://reference.wolfram.com/language/ref/TimeSeriesResample.html
        ///</summary>
        public static Engine TimeSeriesResample(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TimeSeriesResample[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///rescales the times in time series tseries to run from tmin to tmax.
        ///https://reference.wolfram.com/language/ref/TimeSeriesRescale.html
        ///</summary>
        public static Engine TimeSeriesRescale(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TimeSeriesRescale[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///shifts the time series tseries to the left or right according to shift.
        ///https://reference.wolfram.com/language/ref/TimeSeriesShift.html
        ///</summary>
        public static Engine TimeSeriesShift(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TimeSeriesShift[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///combines the tseriesi using the function f.
        ///https://reference.wolfram.com/language/ref/TimeSeriesThread.html
        ///</summary>
        public static Engine TimeSeriesThread(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TimeSeriesThread[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the elements of the time series tseries that fall between tmin and tmax.
        ///https://reference.wolfram.com/language/ref/TimeSeriesWindow.html
        ///</summary>
        public static Engine TimeSeriesWindow(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TimeSeriesWindow[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the elements of the time series tseries that satisfy the window specification windowspec.
        ///https://reference.wolfram.com/language/ref/TimeSeriesWindow.html
        ///</summary>
        public static Engine TimeSeriesWindow(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TimeSeriesWindow[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///converts the date object date to the specified time system tsys.
        ///https://reference.wolfram.com/language/ref/TimeSystemConvert.html
        ///</summary>
        public static Engine TimeSystemConvert(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TimeSystemConvert[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///converts to the default time system.
        ///https://reference.wolfram.com/language/ref/TimeSystemConvert.html
        ///</summary>
        public static Engine TimeSystemConvert(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TimeSystemConvert[" + arg0 + "]", name);
        }

        ///<summary>
        ///converts date1 through daten to the specified time system.
        ///https://reference.wolfram.com/language/ref/TimeSystemConvert.html
        ///</summary>
        public static Engine TimeSystemConvert(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("TimeSystemConvert[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the total number of seconds of CPU time used so far in the current Wolfram System session.
        ///https://reference.wolfram.com/language/ref/TimeUsed.html
        ///</summary>
        public static Engine TimeUsed(this Engine en, string? name = null)
        {
            return en.Execute("TimeUsed[]", name);
        }

        ///<summary>
        ///calculates the time value of a security s at time t for an interest specified by i.
        ///https://reference.wolfram.com/language/ref/TimeValue.html
        ///</summary>
        public static Engine TimeValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TimeValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///converts the date or time object time to the specified time zone timezone.
        ///https://reference.wolfram.com/language/ref/TimeZoneConvert.html
        ///</summary>
        public static Engine TimeZoneConvert(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TimeZoneConvert[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///converts to the current $TimeZone value.
        ///https://reference.wolfram.com/language/ref/TimeZoneConvert.html
        ///</summary>
        public static Engine TimeZoneConvert(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TimeZoneConvert[" + arg0 + "]", name);
        }

        ///<summary>
        ///converts time1 through timen to the specified timezone.
        ///https://reference.wolfram.com/language/ref/TimeZoneConvert.html
        ///</summary>
        public static Engine TimeZoneConvert(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("TimeZoneConvert[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the numeric offset between the time zone tz and GMT on the current date.
        ///https://reference.wolfram.com/language/ref/TimeZoneOffset.html
        ///</summary>
        public static Engine TimeZoneOffset(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TimeZoneOffset[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the numeric offset between tz and the specified base time zone.
        ///https://reference.wolfram.com/language/ref/TimeZoneOffset.html
        ///</summary>
        public static Engine TimeZoneOffset(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TimeZoneOffset[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the numeric offset between tz and base on the specified date.
        ///https://reference.wolfram.com/language/ref/TimeZoneOffset.html
        ///</summary>
        public static Engine TimeZoneOffset(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TimeZoneOffset[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///evaluates expr, and returns a list of the time in seconds used, together with the result obtained.
        ///https://reference.wolfram.com/language/ref/Timing.html
        ///</summary>
        public static Engine Timing(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Timing[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the simple Tits group .
        ///https://reference.wolfram.com/language/ref/TitsGroupT.html
        ///</summary>
        public static Engine TitsGroupT(this Engine en, string? name = null)
        {
            return en.Execute("TitsGroupT[]", name);
        }

        ///<summary>
        ///generates boxes corresponding to the printed form of expr in StandardForm.
        ///https://reference.wolfram.com/language/ref/ToBoxes.html
        ///</summary>
        public static Engine ToBoxes(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ToBoxes[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the boxes corresponding to output in the specified form.
        ///https://reference.wolfram.com/language/ref/ToBoxes.html
        ///</summary>
        public static Engine ToBoxes(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ToBoxes[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the integer codes corresponding to the characters in a string.
        ///https://reference.wolfram.com/language/ref/ToCharacterCode.html
        ///</summary>
        public static Engine ToCharacterCode(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ToCharacterCode[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives integer codes according to the specified encoding.
        ///https://reference.wolfram.com/language/ref/ToCharacterCode.html
        ///</summary>
        public static Engine ToCharacterCode(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ToCharacterCode[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the continuous-time approximation of the discrete-time systems models lsys.
        ///https://reference.wolfram.com/language/ref/ToContinuousTimeModel.html
        ///</summary>
        public static Engine ToContinuousTimeModel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ToContinuousTimeModel[" + arg0 + "]", name);
        }

        ///<summary>
        ///specifies the transform variable s.
        ///https://reference.wolfram.com/language/ref/ToContinuousTimeModel.html
        ///</summary>
        public static Engine ToContinuousTimeModel(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ToContinuousTimeModel[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the discrete-time approximation, with sampling period τ, of the continuous-time systems models lsys.
        ///https://reference.wolfram.com/language/ref/ToDiscreteTimeModel.html
        ///</summary>
        public static Engine ToDiscreteTimeModel(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ToDiscreteTimeModel[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///specifies the transform variable z.
        ///https://reference.wolfram.com/language/ref/ToDiscreteTimeModel.html
        ///</summary>
        public static Engine ToDiscreteTimeModel(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ToDiscreteTimeModel[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns an entity object corresponding to the given expression.
        ///https://reference.wolfram.com/language/ref/ToEntity.html
        ///</summary>
        public static Engine ToEntity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ToEntity[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns an entity object of the specified type corresponding to expr.
        ///https://reference.wolfram.com/language/ref/ToEntity.html
        ///</summary>
        public static Engine ToEntity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ToEntity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the n×n Toeplitz matrix with first row and first column being successive integers.
        ///https://reference.wolfram.com/language/ref/ToeplitzMatrix.html
        ///</summary>
        public static Engine ToeplitzMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ToeplitzMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Toeplitz matrix whose first column consists of elements c1, c2, ….
        ///https://reference.wolfram.com/language/ref/ToeplitzMatrix.html
        ///</summary>
        public static Engine ToeplitzMatrix(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ToeplitzMatrix[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the Toeplitz matrix with elements ci down the first column, and ri across the first row.
        ///https://reference.wolfram.com/language/ref/ToeplitzMatrix.html
        ///</summary>
        public static Engine ToeplitzMatrix(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ToeplitzMatrix[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the expression obtained by interpreting strings or boxes as Wolfram Language input.
        ///https://reference.wolfram.com/language/ref/ToExpression.html
        ///</summary>
        public static Engine ToExpression(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ToExpression[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses interpretation rules corresponding to the specified form.
        ///https://reference.wolfram.com/language/ref/ToExpression.html
        ///</summary>
        public static Engine ToExpression(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ToExpression[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///wraps the head h around the expression produced before evaluating it.
        ///https://reference.wolfram.com/language/ref/ToExpression.html
        ///</summary>
        public static Engine ToExpression(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ToExpression[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///puts terms in a sum over a common denominator, and cancels factors in the result.
        ///https://reference.wolfram.com/language/ref/Together.html
        ///</summary>
        public static Engine Together(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Together[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a toggler button with setting x, that toggles between True and False.
        ///https://reference.wolfram.com/language/ref/Toggler.html
        ///</summary>
        public static Engine Toggler(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Toggler[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a toggler button that cycles through any sequence of values vali.
        ///https://reference.wolfram.com/language/ref/Toggler.html
        ///</summary>
        public static Engine Toggler(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Toggler[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///displays as dpict if x is none of the vali.
        ///https://reference.wolfram.com/language/ref/Toggler.html
        ///</summary>
        public static Engine Toggler(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Toggler[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a toggler bar with setting x and with toggler buttons for values vali to include in the list x.
        ///https://reference.wolfram.com/language/ref/TogglerBar.html
        ///</summary>
        public static Engine TogglerBar(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TogglerBar[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns an invertible version of a time series process tproc.
        ///https://reference.wolfram.com/language/ref/ToInvertibleTimeSeries.html
        ///</summary>
        public static Engine ToInvertibleTimeSeries(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ToInvertibleTimeSeries[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields a string in which all letters have been converted to lowercase.
        ///https://reference.wolfram.com/language/ref/ToLowerCase.html
        ///</summary>
        public static Engine ToLowerCase(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ToLowerCase[" + arg0 + "]", name);
        }

        ///<summary>
        ///expresses the algebraic number a in the number field generated by θ.
        ///https://reference.wolfram.com/language/ref/ToNumberField.html
        ///</summary>
        public static Engine ToNumberField(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ToNumberField[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///expresses the ai in the field generated by θ.
        ///https://reference.wolfram.com/language/ref/ToNumberField.html
        ///</summary>
        public static Engine ToNumberField(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("ToNumberField[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///expresses the ai in a common extension field generated by a single algebraic number.
        ///https://reference.wolfram.com/language/ref/ToNumberField.html
        ///</summary>
        public static Engine ToNumberField(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ToNumberField[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///displays label as a tooltip while the mouse pointer is in the area where expr is displayed.
        ///https://reference.wolfram.com/language/ref/Tooltip.html
        ///</summary>
        public static Engine Tooltip(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Tooltip[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a three-dimensional graphics directive specifying that surfaces that follow are to be drawn to emulate two-dimensional flat objects.
        ///https://reference.wolfram.com/language/ref/ToonShading.html
        ///</summary>
        public static Engine ToonShading(this Engine en, string? name = null)
        {
            return en.Execute("ToonShading[]", name);
        }

        ///<summary>
        ///uses the color col as base color.
        ///https://reference.wolfram.com/language/ref/ToonShading.html
        ///</summary>
        public static Engine ToonShading(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ToonShading[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses the dark color dcol, the base color bcol and highlight color hcol.
        ///https://reference.wolfram.com/language/ref/ToonShading.html
        ///</summary>
        public static Engine ToonShading(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ToonShading[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the morphological top-hat transform of image with respect to structuring element ker.
        ///https://reference.wolfram.com/language/ref/TopHatTransform.html
        ///</summary>
        public static Engine TopHatTransform(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TopHatTransform[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the {r,θ} polar coordinates corresponding to the Cartesian coordinates {x,y}.
        ///https://reference.wolfram.com/language/ref/ToPolarCoordinates.html
        ///</summary>
        public static Engine ToPolarCoordinates(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ToPolarCoordinates[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list of vertices of g in topologically sorted order for a directed acyclic graph g.
        ///https://reference.wolfram.com/language/ref/TopologicalSort.html
        ///</summary>
        public static Engine TopologicalSort(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TopologicalSort[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/TopologicalSort.html
        ///</summary>
        public static Engine TopologicalSort(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TopologicalSort[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///attempts to express all Root objects in expr in terms of radicals.
        ///https://reference.wolfram.com/language/ref/ToRadicals.html
        ///</summary>
        public static Engine ToRadicals(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ToRadicals[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a new pointer object in compiled code, suitable for use with external libraries.
        ///https://reference.wolfram.com/language/ref/ToRawPointer.html
        ///</summary>
        public static Engine ToRawPointer(this Engine en, string? name = null)
        {
            return en.Execute("ToRawPointer[]", name);
        }

        ///<summary>
        ///creates a new object pointing to the initial value val.
        ///https://reference.wolfram.com/language/ref/ToRawPointer.html
        ///</summary>
        public static Engine ToRawPointer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ToRawPointer[" + arg0 + "]", name);
        }

        ///<summary>
        ///stores val in the pointer p.
        ///https://reference.wolfram.com/language/ref/ToRawPointer.html
        ///</summary>
        public static Engine ToRawPointer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ToRawPointer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///stores val in the "CArray" array at the given offset.
        ///https://reference.wolfram.com/language/ref/ToRawPointer.html
        ///</summary>
        public static Engine ToRawPointer(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ToRawPointer[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///takes logical combinations of equations, in the form generated by Roots and Reduce, and converts them to lists of rules, of the form produced by Solve.
        ///https://reference.wolfram.com/language/ref/ToRules.html
        ///</summary>
        public static Engine ToRules(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ToRules[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a torus centered at {x,y,z} with inner radius rinner and outer radius router.
        ///https://reference.wolfram.com/language/ref/Torus.html
        ///</summary>
        public static Engine Torus(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Torus[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the k-dimensional torus graph with n1×n2×…×nk vertices.
        ///https://reference.wolfram.com/language/ref/TorusGraph.html
        ///</summary>
        public static Engine TorusGraph(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TorusGraph[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the {r,θ,ϕ} spherical coordinates corresponding to the Cartesian coordinates {x,y,z}.
        ///https://reference.wolfram.com/language/ref/ToSphericalCoordinates.html
        ///</summary>
        public static Engine ToSphericalCoordinates(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ToSphericalCoordinates[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives a string corresponding to the printed form of expr in OutputForm.
        ///https://reference.wolfram.com/language/ref/ToString.html
        ///</summary>
        public static Engine ToString(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ToString[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the string corresponding to output in the specified form.
        ///https://reference.wolfram.com/language/ref/ToString.html
        ///</summary>
        public static Engine ToString(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ToString[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the total of the elements in list.
        ///https://reference.wolfram.com/language/ref/Total.html
        ///</summary>
        public static Engine Total(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Total[" + arg0 + "]", name);
        }

        ///<summary>
        ///totals all elements down to level n.
        ///https://reference.wolfram.com/language/ref/Total.html
        ///</summary>
        public static Engine Total(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Total[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///totals elements at level n.
        ///https://reference.wolfram.com/language/ref/Total.html
        ///</summary>
        public static Engine Total(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Total[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a net layer taking a list of input arrays and performing elementwise addition on them.
        ///https://reference.wolfram.com/language/ref/TotalLayer.html
        ///</summary>
        public static Engine TotalLayer(this Engine en, string? name = null)
        {
            return en.Execute("TotalLayer[]", name);
        }

        ///<summary>
        ///iteratively reduces noise while preserving rapid transitions in data.
        ///https://reference.wolfram.com/language/ref/TotalVariationFilter.html
        ///</summary>
        public static Engine TotalVariationFilter(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TotalVariationFilter[" + arg0 + "]", name);
        }

        ///<summary>
        ///assumes a regularization parameter value param.
        ///https://reference.wolfram.com/language/ref/TotalVariationFilter.html
        ///</summary>
        public static Engine TotalVariationFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TotalVariationFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the list of current positions being touched in the notebook front end.
        ///https://reference.wolfram.com/language/ref/TouchPosition.html
        ///</summary>
        public static Engine TouchPosition(this Engine en, string? name = null)
        {
            return en.Execute("TouchPosition[]", name);
        }

        ///<summary>
        ///gives the touch positions with respect to the specified coordinate system.
        ///https://reference.wolfram.com/language/ref/TouchPosition.html
        ///</summary>
        public static Engine TouchPosition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TouchPosition[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the position of the n position being touched in an object in the specified coordinate system.
        ///https://reference.wolfram.com/language/ref/TouchPosition.html
        ///</summary>
        public static Engine TouchPosition(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TouchPosition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns def if there are not n positions being touched.
        ///https://reference.wolfram.com/language/ref/TouchPosition.html
        ///</summary>
        public static Engine TouchPosition(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TouchPosition[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields a string in which all letters have been converted to uppercase.
        ///https://reference.wolfram.com/language/ref/ToUpperCase.html
        ///</summary>
        public static Engine ToUpperCase(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ToUpperCase[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a video by taking a tour at steps stepi around graphics.
        ///https://reference.wolfram.com/language/ref/TourVideo.html
        ///</summary>
        public static Engine TourVideo(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TourVideo[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///takes a tour with steps stepi at times ti around graphics.
        ///https://reference.wolfram.com/language/ref/TourVideo.html
        ///</summary>
        public static Engine TourVideo(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("TourVideo[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///samples the function func to generate step specifications for each frame.
        ///https://reference.wolfram.com/language/ref/TourVideo.html
        ///</summary>
        public static Engine TourVideo(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TourVideo[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the trace of the matrix or tensor list.
        ///https://reference.wolfram.com/language/ref/Tr.html
        ///</summary>
        public static Engine Tr(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Tr[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds a generalized trace, combining terms with f instead of Plus.
        ///https://reference.wolfram.com/language/ref/Tr.html
        ///</summary>
        public static Engine Tr(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Tr[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///goes down to level n in list.
        ///https://reference.wolfram.com/language/ref/Tr.html
        ///</summary>
        public static Engine Tr(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Tr[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates a list of all expressions used in the evaluation of expr.
        ///https://reference.wolfram.com/language/ref/Trace.html
        ///</summary>
        public static Engine Trace(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Trace[" + arg0 + "]", name);
        }

        ///<summary>
        ///includes only those expressions that match form.
        ///https://reference.wolfram.com/language/ref/Trace.html
        ///</summary>
        public static Engine Trace(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Trace[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///initiates a dialog for every expression used in the evaluation of expr.
        ///https://reference.wolfram.com/language/ref/TraceDialog.html
        ///</summary>
        public static Engine TraceDialog(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TraceDialog[" + arg0 + "]", name);
        }

        ///<summary>
        ///initiates a dialog only for expressions which match form.
        ///https://reference.wolfram.com/language/ref/TraceDialog.html
        ///</summary>
        public static Engine TraceDialog(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TraceDialog[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///prints all expressions used in the evaluation of expr.
        ///https://reference.wolfram.com/language/ref/TracePrint.html
        ///</summary>
        public static Engine TracePrint(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TracePrint[" + arg0 + "]", name);
        }

        ///<summary>
        ///includes only those expressions which match form.
        ///https://reference.wolfram.com/language/ref/TracePrint.html
        ///</summary>
        public static Engine TracePrint(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TracePrint[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies f to all expressions used in the evaluation of expr.
        ///https://reference.wolfram.com/language/ref/TraceScan.html
        ///</summary>
        public static Engine TraceScan(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TraceScan[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///includes only those expressions which match form.
        ///https://reference.wolfram.com/language/ref/TraceScan.html
        ///</summary>
        public static Engine TraceScan(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TraceScan[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///applies f before evaluation and fp after evaluation to expressions used in the evaluation of expr.
        ///https://reference.wolfram.com/language/ref/TraceScan.html
        ///</summary>
        public static Engine TraceScan(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("TraceScan[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a Tracy–Widom distribution with Dyson index β.
        ///https://reference.wolfram.com/language/ref/TracyWidomDistribution.html
        ///</summary>
        public static Engine TracyWidomDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TracyWidomDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes a chart showing prices and volume for each date.
        ///https://reference.wolfram.com/language/ref/TradingChart.html
        ///</summary>
        public static Engine TradingChart(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TradingChart[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///makes a financial chart for the financial entity "name" over the daterange.
        ///https://reference.wolfram.com/language/ref/TradingChart.html
        ///</summary>
        public static Engine TradingChart(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TradingChart[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///makes a financial chart with indicators ind1, ind2, ….
        ///https://reference.wolfram.com/language/ref/TradingChart.html
        ///</summary>
        public static Engine TradingChart(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TradingChart[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///prints as an approximation to the traditional mathematical notation for expr.
        ///https://reference.wolfram.com/language/ref/TraditionalForm.html
        ///</summary>
        public static Engine TraditionalForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TraditionalForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///trains a ContentDetectorFunction[…] based on the examples given.
        ///https://reference.wolfram.com/language/ref/TrainImageContentDetector.html
        ///</summary>
        public static Engine TrainImageContentDetector(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TrainImageContentDetector[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///trains a ContentDetectorFunction[…] based on the examples given.
        ///https://reference.wolfram.com/language/ref/TrainTextContentDetector.html
        ///</summary>
        public static Engine TrainTextContentDetector(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TrainTextContentDetector[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///cancels common poles and zeros in the TransferFunctionModel tfm.
        ///https://reference.wolfram.com/language/ref/TransferFunctionCancel.html
        ///</summary>
        public static Engine TransferFunctionCancel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TransferFunctionCancel[" + arg0 + "]", name);
        }

        ///<summary>
        ///cancels only common pole-zero pairs ei for which crit[ei] is True.
        ///https://reference.wolfram.com/language/ref/TransferFunctionCancel.html
        ///</summary>
        public static Engine TransferFunctionCancel(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TransferFunctionCancel[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///expands polynomial terms in the numerators and denominators of the TransferFunctionModel tfm.
        ///https://reference.wolfram.com/language/ref/TransferFunctionExpand.html
        ///</summary>
        public static Engine TransferFunctionExpand(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TransferFunctionExpand[" + arg0 + "]", name);
        }

        ///<summary>
        ///factors the polynomial terms in the numerators and denominators of the TransferFunctionModel tfm.
        ///https://reference.wolfram.com/language/ref/TransferFunctionFactor.html
        ///</summary>
        public static Engine TransferFunctionFactor(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TransferFunctionFactor[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the model of the transfer-function matrix m with complex variable s.
        ///https://reference.wolfram.com/language/ref/TransferFunctionModel.html
        ///</summary>
        public static Engine TransferFunctionModel(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TransferFunctionModel[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///specifies the numerator num and denominator den of a transfer-function model.
        ///https://reference.wolfram.com/language/ref/TransferFunctionModel.html
        ///</summary>
        public static Engine TransferFunctionModel(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("TransferFunctionModel[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the transfer-function model of the systems model sys.
        ///https://reference.wolfram.com/language/ref/TransferFunctionModel.html
        ///</summary>
        public static Engine TransferFunctionModel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TransferFunctionModel[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a matrix of roots of the denominators in the TransferFunctionModel tfm.
        ///https://reference.wolfram.com/language/ref/TransferFunctionPoles.html
        ///</summary>
        public static Engine TransferFunctionPoles(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TransferFunctionPoles[" + arg0 + "]", name);
        }

        ///<summary>
        ///only gives the roots inside the region reg on the complex plane.
        ///https://reference.wolfram.com/language/ref/TransferFunctionPoles.html
        ///</summary>
        public static Engine TransferFunctionPoles(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TransferFunctionPoles[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///transforms the TransferFunctionModel object tf using the transformation function f.
        ///https://reference.wolfram.com/language/ref/TransferFunctionTransform.html
        ///</summary>
        public static Engine TransferFunctionTransform(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TransferFunctionTransform[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a matrix of roots of the numerators in the TransferFunctionModel tfm.
        ///https://reference.wolfram.com/language/ref/TransferFunctionZeros.html
        ///</summary>
        public static Engine TransferFunctionZeros(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TransferFunctionZeros[" + arg0 + "]", name);
        }

        ///<summary>
        ///only gives the roots inside the region reg on the complex plane.
        ///https://reference.wolfram.com/language/ref/TransferFunctionZeros.html
        ///</summary>
        public static Engine TransferFunctionZeros(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TransferFunctionZeros[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a transformation function that applies geometric and other transformations.
        ///https://reference.wolfram.com/language/ref/TransformationFunction.html
        ///</summary>
        public static Engine TransformationFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TransformationFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the homogeneous matrix associated with a TransformationFunction object.
        ///https://reference.wolfram.com/language/ref/TransformationMatrix.html
        ///</summary>
        public static Engine TransformationMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TransformationMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the transformed distribution of expr where the random variable x follows the distribution dist.
        ///https://reference.wolfram.com/language/ref/TransformedDistribution.html
        ///</summary>
        public static Engine TransformedDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TransformedDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a transformed distribution where x1, x2, … are independent and follow the distributions dist1, dist2, ….
        ///https://reference.wolfram.com/language/ref/TransformedDistribution.html
        ///</summary>
        public static Engine TransformedDistribution(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TransformedDistribution[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses the coordinate transformation t to transform the scalar, vector, or tensor field f from coordinates xi to yi.
        ///https://reference.wolfram.com/language/ref/TransformedField.html
        ///</summary>
        public static Engine TransformedField(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("TransformedField[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents the transformed process of expr where the variable x follows the random process proc and t denotes the time.
        ///https://reference.wolfram.com/language/ref/TransformedProcess.html
        ///</summary>
        public static Engine TransformedProcess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TransformedProcess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a transformed process where x1, x2, … are independent and follow the processes proc1, proc2, ….
        ///https://reference.wolfram.com/language/ref/TransformedProcess.html
        ///</summary>
        public static Engine TransformedProcess(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("TransformedProcess[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the transformed region , where reg is a region and f is a function.
        ///https://reference.wolfram.com/language/ref/TransformedRegion.html
        ///</summary>
        public static Engine TransformedRegion(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TransformedRegion[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the transitive closure of the graph g.
        ///https://reference.wolfram.com/language/ref/TransitiveClosureGraph.html
        ///</summary>
        public static Engine TransitiveClosureGraph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TransitiveClosureGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/TransitiveClosureGraph.html
        ///</summary>
        public static Engine TransitiveClosureGraph(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TransitiveClosureGraph[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives a transitive reduction of the graph g.
        ///https://reference.wolfram.com/language/ref/TransitiveReductionGraph.html
        ///</summary>
        public static Engine TransitiveReductionGraph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TransitiveReductionGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/TransitiveReductionGraph.html
        ///</summary>
        public static Engine TransitiveReductionGraph(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TransitiveReductionGraph[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents graphics primitives g translated by the vector {x,y,…}.
        ///https://reference.wolfram.com/language/ref/Translate.html
        ///</summary>
        public static Engine Translate(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Translate[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents multiple copies of g translated by a collection of vectors.
        ///https://reference.wolfram.com/language/ref/Translate.html
        ///</summary>
        public static Engine Translate(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Translate[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives a TransformationFunction that represents translation of points by a vector v.
        ///https://reference.wolfram.com/language/ref/TranslationTransform.html
        ///</summary>
        public static Engine TranslationTransform(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TranslationTransform[" + arg0 + "]", name);
        }

        ///<summary>
        ///attempts to transliterate string into plain ASCII.
        ///https://reference.wolfram.com/language/ref/Transliterate.html
        ///</summary>
        public static Engine Transliterate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Transliterate[" + arg0 + "]", name);
        }

        ///<summary>
        ///attempts to transliterate string into the specified writing script script.
        ///https://reference.wolfram.com/language/ref/Transliterate.html
        ///</summary>
        public static Engine Transliterate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Transliterate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///transposes the first two levels in list.
        ///https://reference.wolfram.com/language/ref/Transpose.html
        ///</summary>
        public static Engine Transpose(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Transpose[" + arg0 + "]", name);
        }

        ///<summary>
        ///transposes list so that the k level in list is the nk level in the result.
        ///https://reference.wolfram.com/language/ref/Transpose.html
        ///</summary>
        public static Engine Transpose(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Transpose[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///transposes levels m and n in list, leaving all other levels unchanged.
        ///https://reference.wolfram.com/language/ref/Transpose.html
        ///</summary>
        public static Engine Transpose(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Transpose[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a net layer that transposes the first two levels of its input.
        ///https://reference.wolfram.com/language/ref/TransposeLayer.html
        ///</summary>
        public static Engine TransposeLayer(this Engine en, string? name = null)
        {
            return en.Execute("TransposeLayer[]", name);
        }

        ///<summary>
        ///represents a net layer that transposes levels m and n of its input.
        ///https://reference.wolfram.com/language/ref/TransposeLayer.html
        ///</summary>
        public static Engine TransposeLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TransposeLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a net layer that sequentially transposes levels mi and ni of its input.
        ///https://reference.wolfram.com/language/ref/TransposeLayer.html
        ///</summary>
        public static Engine TransposeLayer(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TransposeLayer[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates directions for travel from loc1 to loc2, ….
        ///https://reference.wolfram.com/language/ref/TravelDirections.html
        ///</summary>
        public static Engine TravelDirections(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TravelDirections[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the property prop of travel directions.
        ///https://reference.wolfram.com/language/ref/TravelDirections.html
        ///</summary>
        public static Engine TravelDirections(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("TravelDirections[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents travel directions generated by TravelDirections.
        ///https://reference.wolfram.com/language/ref/TravelDirectionsData.html
        ///</summary>
        public static Engine TravelDirectionsData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TravelDirectionsData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the estimated distance for travel from loc1 to loc2, ….
        ///https://reference.wolfram.com/language/ref/TravelDistance.html
        ///</summary>
        public static Engine TravelDistance(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TravelDistance[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///returns the list {TravelDistance[loc1,loc2],…,TravelDistance[locn-1,locn]}.
        ///https://reference.wolfram.com/language/ref/TravelDistanceList.html
        ///</summary>
        public static Engine TravelDistanceList(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TravelDistanceList[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the estimated time to travel from loc1 to loc2, ….
        ///https://reference.wolfram.com/language/ref/TravelTime.html
        ///</summary>
        public static Engine TravelTime(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TravelTime[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a tree with a list of child subtrees subtreei.
        ///https://reference.wolfram.com/language/ref/Tree.html
        ///</summary>
        public static Engine Tree(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Tree[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///specifies the children as an association with keys keyi.
        ///https://reference.wolfram.com/language/ref/Tree.html
        ///</summary>
        public static Engine Tree(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Tree[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a tree containing data in its root, with children given by subtrees.
        ///https://reference.wolfram.com/language/ref/Tree.html
        ///</summary>
        public static Engine Tree(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Tree[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of subtrees of tree with data matching pattern.
        ///https://reference.wolfram.com/language/ref/TreeCases.html
        ///</summary>
        public static Engine TreeCases(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TreeCases[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of all subtrees of tree on levels specified by levelspec with data that matches the pattern.
        ///https://reference.wolfram.com/language/ref/TreeCases.html
        ///</summary>
        public static Engine TreeCases(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TreeCases[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the first n subtrees in tree with data that matches the pattern.
        ///https://reference.wolfram.com/language/ref/TreeCases.html
        ///</summary>
        public static Engine TreeCases(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("TreeCases[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents an operator form of TreeCases that can be applied to a tree.
        ///https://reference.wolfram.com/language/ref/TreeCases.html
        ///</summary>
        public static Engine TreeCases(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeCases[" + arg0 + "]", name);
        }

        ///<summary>
        ///extracts the children of the root of the Tree object tree.
        ///https://reference.wolfram.com/language/ref/TreeChildren.html
        ///</summary>
        public static Engine TreeChildren(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeChildren[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the number of subtrees of tree whose data matches pattern.
        ///https://reference.wolfram.com/language/ref/TreeCount.html
        ///</summary>
        public static Engine TreeCount(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TreeCount[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the total number of subtrees with data matching pattern that appear at the levels in tree specified by levelspec.
        ///https://reference.wolfram.com/language/ref/TreeCount.html
        ///</summary>
        public static Engine TreeCount(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TreeCount[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of TreeCount that can be applied to a tree.
        ///https://reference.wolfram.com/language/ref/TreeCount.html
        ///</summary>
        public static Engine TreeCount(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeCount[" + arg0 + "]", name);
        }

        ///<summary>
        ///extracts the data in the root of the Tree object tree.
        ///https://reference.wolfram.com/language/ref/TreeData.html
        ///</summary>
        public static Engine TreeData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeData[" + arg0 + "]", name);
        }

        ///<summary>
        ///deletes the subtree of tree at the position specified by pos.
        ///https://reference.wolfram.com/language/ref/TreeDelete.html
        ///</summary>
        public static Engine TreeDelete(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TreeDelete[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///deletes subtrees at several positions.
        ///https://reference.wolfram.com/language/ref/TreeDelete.html
        ///</summary>
        public static Engine TreeDelete(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TreeDelete[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents an operator form of TreeDelete that can be applied to a tree.
        ///https://reference.wolfram.com/language/ref/TreeDelete.html
        ///</summary>
        public static Engine TreeDelete(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeDelete[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the maximum level of tree.
        ///https://reference.wolfram.com/language/ref/TreeDepth.html
        ///</summary>
        public static Engine TreeDepth(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeDepth[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the maximum level of the subtree with data matching pattern.
        ///https://reference.wolfram.com/language/ref/TreeDepth.html
        ///</summary>
        public static Engine TreeDepth(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TreeDepth[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives an expression from the structure of the Tree object tree.
        ///https://reference.wolfram.com/language/ref/TreeExpression.html
        ///</summary>
        public static Engine TreeExpression(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeExpression[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an expression with data and subtrees of tree interpreted as specified by struct.
        ///https://reference.wolfram.com/language/ref/TreeExpression.html
        ///</summary>
        public static Engine TreeExpression(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TreeExpression[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///extracts the subtree of tree at the position specified by pos.
        ///https://reference.wolfram.com/language/ref/TreeExtract.html
        ///</summary>
        public static Engine TreeExtract(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TreeExtract[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///extracts a list of subtrees of tree.
        ///https://reference.wolfram.com/language/ref/TreeExtract.html
        ///</summary>
        public static Engine TreeExtract(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TreeExtract[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///extracts subtrees of tree, applying h to each subtree.
        ///https://reference.wolfram.com/language/ref/TreeExtract.html
        ///</summary>
        public static Engine TreeExtract(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TreeExtract[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of TreeExtract that can be applied to a tree.
        ///https://reference.wolfram.com/language/ref/TreeExtract.html
        ///</summary>
        public static Engine TreeExtract(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeExtract[" + arg0 + "]", name);
        }

        ///<summary>
        ///successively folds the subtrees of tree, applying f to both the data of each subtree and the list of results for its children.
        ///https://reference.wolfram.com/language/ref/TreeFold.html
        ///</summary>
        public static Engine TreeFold(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TreeFold[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies f to h[tree] instead of the data of tree.
        ///https://reference.wolfram.com/language/ref/TreeFold.html
        ///</summary>
        public static Engine TreeFold(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TreeFold[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///applies f-1 at the last level and f at each inner level.
        ///https://reference.wolfram.com/language/ref/TreeFold.html
        ///</summary>
        public static Engine TreeFold(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TreeFold[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of TreeFold that can be applied to a tree.
        ///https://reference.wolfram.com/language/ref/TreeFold.html
        ///</summary>
        public static Engine TreeFold(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeFold[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays expr as a tree with different levels at different depths.
        ///https://reference.wolfram.com/language/ref/TreeForm.html
        ///</summary>
        public static Engine TreeForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays expr as a tree only down to level n.
        ///https://reference.wolfram.com/language/ref/TreeForm.html
        ///</summary>
        public static Engine TreeForm(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TreeForm[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields a tree where ui is the predecessor of vi.
        ///https://reference.wolfram.com/language/ref/TreeGraph.html
        ///</summary>
        public static Engine TreeGraph(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TreeGraph[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///yields a tree with edges ej.
        ///https://reference.wolfram.com/language/ref/TreeGraph.html
        ///</summary>
        public static Engine TreeGraph(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TreeGraph[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is a tree and False otherwise.
        ///https://reference.wolfram.com/language/ref/TreeGraphQ.html
        ///</summary>
        public static Engine TreeGraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeGraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///inserts child at the position specified by pos in tree.
        ///https://reference.wolfram.com/language/ref/TreeInsert.html
        ///</summary>
        public static Engine TreeInsert(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TreeInsert[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///inserts child at several positions.
        ///https://reference.wolfram.com/language/ref/TreeInsert.html
        ///</summary>
        public static Engine TreeInsert(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("TreeInsert[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents an operator form of TreeInsert that can be applied to a tree.
        ///https://reference.wolfram.com/language/ref/TreeInsert.html
        ///</summary>
        public static Engine TreeInsert(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TreeInsert[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the number of leaves of tree.
        ///https://reference.wolfram.com/language/ref/TreeLeafCount.html
        ///</summary>
        public static Engine TreeLeafCount(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeLeafCount[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if tree is a Tree object with no children, and gives False otherwise.
        ///https://reference.wolfram.com/language/ref/TreeLeafQ.html
        ///</summary>
        public static Engine TreeLeafQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeLeafQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the list of leaves of the tree tree.
        ///https://reference.wolfram.com/language/ref/TreeLeaves.html
        ///</summary>
        public static Engine TreeLeaves(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeLeaves[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of all subtrees of tree on levels specified by levelspec.
        ///https://reference.wolfram.com/language/ref/TreeLevel.html
        ///</summary>
        public static Engine TreeLevel(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TreeLevel[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of TreeLevel that can be applied to a tree.
        ///https://reference.wolfram.com/language/ref/TreeLevel.html
        ///</summary>
        public static Engine TreeLevel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeLevel[" + arg0 + "]", name);
        }

        ///<summary>
        ///applies f to the data of each subtree of tree.
        ///https://reference.wolfram.com/language/ref/TreeMap.html
        ///</summary>
        public static Engine TreeMap(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TreeMap[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies f to the data of subtrees on levels of tree specified by levelspec.
        ///https://reference.wolfram.com/language/ref/TreeMap.html
        ///</summary>
        public static Engine TreeMap(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TreeMap[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of TreeMap that can be applied to a tree.
        ///https://reference.wolfram.com/language/ref/TreeMap.html
        ///</summary>
        public static Engine TreeMap(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeMap[" + arg0 + "]", name);
        }

        ///<summary>
        ///applies f to the data at the position specified by pos in tree.
        ///https://reference.wolfram.com/language/ref/TreeMapAt.html
        ///</summary>
        public static Engine TreeMapAt(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TreeMapAt[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///applies f to the data at several positions.
        ///https://reference.wolfram.com/language/ref/TreeMapAt.html
        ///</summary>
        public static Engine TreeMapAt(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("TreeMapAt[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents an operator form of TreeMapAt that can be applied to a tree.
        ///https://reference.wolfram.com/language/ref/TreeMapAt.html
        ///</summary>
        public static Engine TreeMapAt(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TreeMapAt[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives an outline of the data in tree as a nested OpenerView.
        ///https://reference.wolfram.com/language/ref/TreeOutline.html
        ///</summary>
        public static Engine TreeOutline(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeOutline[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an outline of the data in tree initially opened to the subtree at the position specified by pos.
        ///https://reference.wolfram.com/language/ref/TreeOutline.html
        ///</summary>
        public static Engine TreeOutline(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TreeOutline[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///opens the outline to several positions.
        ///https://reference.wolfram.com/language/ref/TreeOutline.html
        ///</summary>
        public static Engine TreeOutline(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TreeOutline[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list of the positions of subtrees of tree whose data matches pattern.
        ///https://reference.wolfram.com/language/ref/TreePosition.html
        ///</summary>
        public static Engine TreePosition(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TreePosition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds only matches that appear on levels of tree specified by levelspec.
        ///https://reference.wolfram.com/language/ref/TreePosition.html
        ///</summary>
        public static Engine TreePosition(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TreePosition[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the positions of the first n matches found.
        ///https://reference.wolfram.com/language/ref/TreePosition.html
        ///</summary>
        public static Engine TreePosition(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("TreePosition[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents an operator form of TreePosition that can be applied to a tree.
        ///https://reference.wolfram.com/language/ref/TreePosition.html
        ///</summary>
        public static Engine TreePosition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreePosition[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if tree is a valid Tree object and False otherwise.
        ///https://reference.wolfram.com/language/ref/TreeQ.html
        ///</summary>
        public static Engine TreeQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a tree in which the subtree of tree at the position specified by pos is replaced with new.
        ///https://reference.wolfram.com/language/ref/TreeReplacePart.html
        ///</summary>
        public static Engine TreeReplacePart(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TreeReplacePart[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///replaces subtrees at positions specified by posi with newi.
        ///https://reference.wolfram.com/language/ref/TreeReplacePart.html
        ///</summary>
        public static Engine TreeReplacePart(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TreeReplacePart[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents an operator form of TreeReplacePart that can be applied to a tree.
        ///https://reference.wolfram.com/language/ref/TreeReplacePart.html
        ///</summary>
        public static Engine TreeReplacePart(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeReplacePart[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the rules associated with the Tree object tree.
        ///https://reference.wolfram.com/language/ref/TreeRules.html
        ///</summary>
        public static Engine TreeRules(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeRules[" + arg0 + "]", name);
        }

        ///<summary>
        ///evaluates f applied to the data of each subtree of tree in turn.
        ///https://reference.wolfram.com/language/ref/TreeScan.html
        ///</summary>
        public static Engine TreeScan(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TreeScan[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies f to the data of subtrees on levels of tree specified by levelspec.
        ///https://reference.wolfram.com/language/ref/TreeScan.html
        ///</summary>
        public static Engine TreeScan(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TreeScan[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of TreeScan that can be applied to a tree.
        ///https://reference.wolfram.com/language/ref/TreeScan.html
        ///</summary>
        public static Engine TreeScan(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeScan[" + arg0 + "]", name);
        }

        ///<summary>
        ///picks out all subtrees treei of tree for which crit[treei] is True.
        ///https://reference.wolfram.com/language/ref/TreeSelect.html
        ///</summary>
        public static Engine TreeSelect(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TreeSelect[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///picks out the first n subtrees for which crit[treei] is True.
        ///https://reference.wolfram.com/language/ref/TreeSelect.html
        ///</summary>
        public static Engine TreeSelect(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TreeSelect[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///picks out subtrees on levels specified by levelspec.
        ///https://reference.wolfram.com/language/ref/TreeSelect.html
        ///</summary>
        public static Engine TreeSelect(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("TreeSelect[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents an operator form of TreeSelect that can be applied to a tree.
        ///https://reference.wolfram.com/language/ref/TreeSelect.html
        ///</summary>
        public static Engine TreeSelect(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeSelect[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the number of subtrees of tree.
        ///https://reference.wolfram.com/language/ref/TreeSize.html
        ///</summary>
        public static Engine TreeSize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TreeSize[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a filled triangle with corner points p1, p2, and p3.
        ///https://reference.wolfram.com/language/ref/Triangle.html
        ///</summary>
        public static Engine Triangle(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Triangle[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the specified type of center for the triangle tri.
        ///https://reference.wolfram.com/language/ref/TriangleCenter.html
        ///</summary>
        public static Engine TriangleCenter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TriangleCenter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the centroid of the triangle.
        ///https://reference.wolfram.com/language/ref/TriangleCenter.html
        ///</summary>
        public static Engine TriangleCenter(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TriangleCenter[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the specified type of construct for the triangle tri.
        ///https://reference.wolfram.com/language/ref/TriangleConstruct.html
        ///</summary>
        public static Engine TriangleConstruct(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TriangleConstruct[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified type of measurement for the triangle tri.
        ///https://reference.wolfram.com/language/ref/TriangleMeasurement.html
        ///</summary>
        public static Engine TriangleMeasurement(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TriangleMeasurement[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a triangle wave that varies between  and  with unit period.
        ///https://reference.wolfram.com/language/ref/TriangleWave.html
        ///</summary>
        public static Engine TriangleWave(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TriangleWave[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a triangle wave that varies between min and max with unit period.
        ///https://reference.wolfram.com/language/ref/TriangleWave.html
        ///</summary>
        public static Engine TriangleWave(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("TriangleWave[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a symmetric triangular statistical distribution giving values between min and max.
        ///https://reference.wolfram.com/language/ref/TriangularDistribution.html
        ///</summary>
        public static Engine TriangularDistribution(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TriangularDistribution[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a symmetric triangular statistical distribution giving values between 0 and 1.
        ///https://reference.wolfram.com/language/ref/TriangularDistribution.html
        ///</summary>
        public static Engine TriangularDistribution(this Engine en, string? name = null)
        {
            return en.Execute("TriangularDistribution[]", name);
        }

        ///<summary>
        ///represents a triangular distribution with mode at c.
        ///https://reference.wolfram.com/language/ref/TriangularDistribution.html
        ///</summary>
        public static Engine TriangularDistribution(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("TriangularDistribution[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a triangulation of the mesh region mr.
        ///https://reference.wolfram.com/language/ref/TriangulateMesh.html
        ///</summary>
        public static Engine TriangulateMesh(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TriangulateMesh[" + arg0 + "]", name);
        }

        ///<summary>
        ///expands out trigonometric functions in expr.
        ///https://reference.wolfram.com/language/ref/TrigExpand.html
        ///</summary>
        public static Engine TrigExpand(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TrigExpand[" + arg0 + "]", name);
        }

        ///<summary>
        ///factors trigonometric functions in expr.
        ///https://reference.wolfram.com/language/ref/TrigFactor.html
        ///</summary>
        public static Engine TrigFactor(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TrigFactor[" + arg0 + "]", name);
        }

        ///<summary>
        ///factors trigonometric functions in expr, yielding a list of lists containing trigonometric monomials and exponents.
        ///https://reference.wolfram.com/language/ref/TrigFactorList.html
        ///</summary>
        public static Engine TrigFactorList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TrigFactorList[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a trigger that can be pressed to make the dynamically updated value of u be continually increased with time from 0 to 1.
        ///https://reference.wolfram.com/language/ref/Trigger.html
        ///</summary>
        public static Engine Trigger(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Trigger[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes u vary from umin to umax when triggered.
        ///https://reference.wolfram.com/language/ref/Trigger.html
        ///</summary>
        public static Engine Trigger(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Trigger[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///makes the value of u increase at a rate of ups units per second when triggered.
        ///https://reference.wolfram.com/language/ref/Trigger.html
        ///</summary>
        public static Engine Trigger(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("Trigger[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///rewrites products and powers of trigonometric functions in expr in terms of trigonometric functions with combined arguments.
        ///https://reference.wolfram.com/language/ref/TrigReduce.html
        ///</summary>
        public static Engine TrigReduce(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TrigReduce[" + arg0 + "]", name);
        }

        ///<summary>
        ///converts trigonometric functions in expr to exponentials.
        ///https://reference.wolfram.com/language/ref/TrigToExp.html
        ///</summary>
        public static Engine TrigToExp(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TrigToExp[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the mean of the elements in list after dropping a fraction f of the smallest and largest elements.
        ///https://reference.wolfram.com/language/ref/TrimmedMean.html
        ///</summary>
        public static Engine TrimmedMean(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TrimmedMean[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the mean when a fraction f1 of the smallest elements and a fraction f2 of the largest elements are removed.
        ///https://reference.wolfram.com/language/ref/TrimmedMean.html
        ///</summary>
        public static Engine TrimmedMean(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TrimmedMean[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the 5% trimmed mean TrimmedMean[list,0.05].
        ///https://reference.wolfram.com/language/ref/TrimmedMean.html
        ///</summary>
        public static Engine TrimmedMean(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TrimmedMean[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the variance of the elements in list after dropping a fraction f of the smallest and largest elements.
        ///https://reference.wolfram.com/language/ref/TrimmedVariance.html
        ///</summary>
        public static Engine TrimmedVariance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TrimmedVariance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the variance when a fraction f1 of the smallest elements and a fraction f2 of the largest elements are removed.
        ///https://reference.wolfram.com/language/ref/TrimmedVariance.html
        ///</summary>
        public static Engine TrimmedVariance(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TrimmedVariance[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the 5% trimmed variance TrimmedVariance[list,0.05].
        ///https://reference.wolfram.com/language/ref/TrimmedVariance.html
        ///</summary>
        public static Engine TrimmedVariance(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TrimmedVariance[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the tropical storm entity.
        ///https://reference.wolfram.com/language/ref/TropicalStormData.html
        ///</summary>
        public static Engine TropicalStormData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TropicalStormData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified tropical storm entities.
        ///https://reference.wolfram.com/language/ref/TropicalStormData.html
        ///</summary>
        public static Engine TropicalStormData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("TropicalStormData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/TropicalStormData.html
        ///</summary>
        public static Engine TropicalStormData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TropicalStormData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields True if expr is True, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/TrueQ.html
        ///</summary>
        public static Engine TrueQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TrueQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the distribution obtained by truncating the values of dist to lie between xmin and xmax.
        ///https://reference.wolfram.com/language/ref/TruncatedDistribution.html
        ///</summary>
        public static Engine TruncatedDistribution(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("TruncatedDistribution[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the distribution obtained by truncating the values of the multivariate distribution dist to lie between xmin and xmax, ymin and ymax, etc.
        ///https://reference.wolfram.com/language/ref/TruncatedDistribution.html
        ///</summary>
        public static Engine TruncatedDistribution(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("TruncatedDistribution[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the truncated polyhedron of poly by truncating all vertices.
        ///https://reference.wolfram.com/language/ref/TruncatedPolyhedron.html
        ///</summary>
        public static Engine TruncatedPolyhedron(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TruncatedPolyhedron[" + arg0 + "]", name);
        }

        ///<summary>
        ///truncates the polyhedron poly by a length ratio l at its vertices.
        ///https://reference.wolfram.com/language/ref/TruncatedPolyhedron.html
        ///</summary>
        public static Engine TruncatedPolyhedron(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TruncatedPolyhedron[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Tsallis -exponential distribution with scale inversely proportional to parameter λ.
        ///https://reference.wolfram.com/language/ref/TsallisQExponentialDistribution.html
        ///</summary>
        public static Engine TsallisQExponentialDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TsallisQExponentialDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Tsallis -Gaussian distribution with mean μ, scale parameter β, and deformation parameter q.
        ///https://reference.wolfram.com/language/ref/TsallisQGaussianDistribution.html
        ///</summary>
        public static Engine TsallisQGaussianDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TsallisQGaussianDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a Tsallis -Gaussian distribution with mean 0 and scale parameter 1.
        ///https://reference.wolfram.com/language/ref/TsallisQGaussianDistribution.html
        ///</summary>
        public static Engine TsallisQGaussianDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TsallisQGaussianDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the mean of data is zero.
        ///https://reference.wolfram.com/language/ref/TTest.html
        ///</summary>
        public static Engine TTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the means of data1 and data2 are equal.
        ///https://reference.wolfram.com/language/ref/TTest.html
        ///</summary>
        public static Engine TTest(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("TTest[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///tests the mean against μ0.
        ///https://reference.wolfram.com/language/ref/TTest.html
        ///</summary>
        public static Engine TTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/TTest.html
        ///</summary>
        public static Engine TTest(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TTest[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a 3D tube around the line joining a sequence of points.
        ///https://reference.wolfram.com/language/ref/Tube.html
        ///</summary>
        public static Engine Tube(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Tube[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a tube of radius r.
        ///https://reference.wolfram.com/language/ref/Tube.html
        ///</summary>
        public static Engine Tube(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Tube[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a collection of tubes.
        ///https://reference.wolfram.com/language/ref/Tube.html
        ///</summary>
        public static Engine Tube(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("Tube[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a tube around the specified 3D curve.
        ///https://reference.wolfram.com/language/ref/Tube.html
        ///</summary>
        public static Engine Tube(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Tube[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents Tukey's lambda distribution with shape parameter λ.
        ///https://reference.wolfram.com/language/ref/TukeyLambdaDistribution.html
        ///</summary>
        public static Engine TukeyLambdaDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TukeyLambdaDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents Tukey's lambda distribution with location parameter μ and scale parameter σ.
        ///https://reference.wolfram.com/language/ref/TukeyLambdaDistribution.html
        ///</summary>
        public static Engine TukeyLambdaDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TukeyLambdaDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the generalized Tukey's lambda distribution with location parameter μ, scale parameters σ1 and σ2, and shape parameters λ1 and λ2.
        ///https://reference.wolfram.com/language/ref/TukeyLambdaDistribution.html
        ///</summary>
        public static Engine TukeyLambdaDistribution(this Engine en, List<object> arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("TukeyLambdaDistribution[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents a Tukey window function of x.
        ///https://reference.wolfram.com/language/ref/TukeyWindow.html
        ///</summary>
        public static Engine TukeyWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TukeyWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses the parameter α.
        ///https://reference.wolfram.com/language/ref/TukeyWindow.html
        ///</summary>
        public static Engine TukeyWindow(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TukeyWindow[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the tunnel entity.
        ///https://reference.wolfram.com/language/ref/TunnelData.html
        ///</summary>
        public static Engine TunnelData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TunnelData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified tunnel entities.
        ///https://reference.wolfram.com/language/ref/TunnelData.html
        ///</summary>
        public static Engine TunnelData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("TunnelData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/TunnelData.html
        ///</summary>
        public static Engine TunnelData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TunnelData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates a list of all possible n‐tuples of elements from list.
        ///https://reference.wolfram.com/language/ref/Tuples.html
        ///</summary>
        public static Engine Tuples(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Tuples[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a list of all possible tuples whose i element is from listi.
        ///https://reference.wolfram.com/language/ref/Tuples.html
        ///</summary>
        public static Engine Tuples(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Tuples[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the k-partite Turán graph with n vertices .
        ///https://reference.wolfram.com/language/ref/TuranGraph.html
        ///</summary>
        public static Engine TuranGraph(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TuranGraph[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a list representing the evolution of the Turing machine with the specified rule from initial condition init for t steps.
        ///https://reference.wolfram.com/language/ref/TuringMachine.html
        ///</summary>
        public static Engine TuringMachine(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TuringMachine[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the result of evolving init for one step.
        ///https://reference.wolfram.com/language/ref/TuringMachine.html
        ///</summary>
        public static Engine TuringMachine(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TuringMachine[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is an operator form of TuringMachine that corresponds to one step of evolution.
        ///https://reference.wolfram.com/language/ref/TuringMachine.html
        ///</summary>
        public static Engine TuringMachine(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TuringMachine[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Tutte polynomial of the graph g.
        ///https://reference.wolfram.com/language/ref/TuttePolynomial.html
        ///</summary>
        public static Engine TuttePolynomial(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TuttePolynomial[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/TuttePolynomial.html
        ///</summary>
        public static Engine TuttePolynomial(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("TuttePolynomial[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an expression that should be assumed to be of a specified type for compilation and other purposes.
        ///https://reference.wolfram.com/language/ref/Typed.html
        ///</summary>
        public static Engine Typed(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Typed[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a declaration of a product type with the specified fields.
        ///https://reference.wolfram.com/language/ref/TypeDeclaration.html
        ///</summary>
        public static Engine TypeDeclaration(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("TypeDeclaration[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///represents a declaration of the abstract type name.
        ///https://reference.wolfram.com/language/ref/TypeDeclaration.html
        ///</summary>
        public static Engine TypeDeclaration(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TypeDeclaration[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a declaration of the type name using the internal representation of targetType.
        ///https://reference.wolfram.com/language/ref/TypeDeclaration.html
        ///</summary>
        public static Engine TypeDeclaration(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("TypeDeclaration[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a type created by evaluating expr.
        ///https://reference.wolfram.com/language/ref/TypeEvaluate.html
        ///</summary>
        public static Engine TypeEvaluate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TypeEvaluate[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the type of expr without evaluating it.
        ///https://reference.wolfram.com/language/ref/TypeOf.html
        ///</summary>
        public static Engine TypeOf(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TypeOf[" + arg0 + "]", name);
        }

        ///<summary>
        ///assumes that instances of x in expr have type ty.
        ///https://reference.wolfram.com/language/ref/TypeOf.html
        ///</summary>
        public static Engine TypeOf(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TypeOf[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///assumes that xi has type tyi.
        ///https://reference.wolfram.com/language/ref/TypeOf.html
        ///</summary>
        public static Engine TypeOf(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("TypeOf[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a type.
        ///https://reference.wolfram.com/language/ref/TypeSpecifier.html
        ///</summary>
        public static Engine TypeSpecifier(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("TypeSpecifier[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a compound type.
        ///https://reference.wolfram.com/language/ref/TypeSpecifier.html
        ///</summary>
        public static Engine TypeSpecifier(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("TypeSpecifier[" + arg0 + ", " + arg1 + "]", name);
        }


    }
}