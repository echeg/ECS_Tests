using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System22 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component345> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component436>())
   {
    q+=1;
    var com = entity.Get<Component436>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component172>())
   {
    q+=1;
    var com = entity.Get<Component172>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component204>())
   {
    q+=1;
    var com = entity.Get<Component204>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component472>())
   {
    q+=1;
    var com = entity.Get<Component472>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
