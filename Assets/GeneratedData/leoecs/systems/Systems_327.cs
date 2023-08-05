using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System327 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component177> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component456>())
   {
    q+=1;
    var com = entity.Get<Component456>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component491>())
   {
    q+=1;
    var com = entity.Get<Component491>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component463>())
   {
    q+=1;
    var com = entity.Get<Component463>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component174>())
   {
    q+=1;
    var com = entity.Get<Component174>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
