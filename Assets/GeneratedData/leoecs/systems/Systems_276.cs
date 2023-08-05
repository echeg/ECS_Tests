using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System276 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component20> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component95>())
   {
    q+=1;
    var com = entity.Get<Component95>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component425>())
   {
    q+=1;
    var com = entity.Get<Component425>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component298>())
   {
    q+=1;
    var com = entity.Get<Component298>();
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
  }
 }
}

}
