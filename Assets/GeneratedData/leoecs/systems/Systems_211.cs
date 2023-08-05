using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System211 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component144> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component119>())
   {
    q+=1;
    var com = entity.Get<Component119>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component277>())
   {
    q+=1;
    var com = entity.Get<Component277>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component346>())
   {
    q+=1;
    var com = entity.Get<Component346>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component263>())
   {
    q+=1;
    var com = entity.Get<Component263>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
