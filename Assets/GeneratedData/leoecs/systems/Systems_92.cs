using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System92 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component455,Component269,Component194> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component329>())
   {
    q+=1;
    var com = entity.Get<Component329>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component244>())
   {
    q+=1;
    var com = entity.Get<Component244>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component419>())
   {
    q+=1;
    var com = entity.Get<Component419>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component468>())
   {
    q+=1;
    var com = entity.Get<Component468>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
