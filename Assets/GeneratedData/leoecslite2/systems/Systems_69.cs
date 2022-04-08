using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System69 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component135>().Inc<Component453>().Inc<Component413>().Inc<Component187>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component152>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component152>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component446>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component446>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component269>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component269>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component396>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component396>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
