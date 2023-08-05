using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System320 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component276,Component84> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component365>())
   {
    q+=1;
    var com = entity.Get<Component365>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component336>())
   {
    q+=1;
    var com = entity.Get<Component336>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component343>())
   {
    q+=1;
    var com = entity.Get<Component343>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component156>())
   {
    q+=1;
    var com = entity.Get<Component156>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
