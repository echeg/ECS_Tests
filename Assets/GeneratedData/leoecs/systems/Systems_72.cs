using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System72 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component477> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component320>())
   {
    q+=1;
    var com = entity.Get<Component320>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component370>())
   {
    q+=1;
    var com = entity.Get<Component370>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component88>())
   {
    q+=1;
    var com = entity.Get<Component88>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component159>())
   {
    q+=1;
    var com = entity.Get<Component159>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
