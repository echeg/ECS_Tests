using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System46 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component206>().Inc<Component255>().Inc<Component189>().Inc<Component379>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component238>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component238>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component458>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component458>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component167>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component167>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component428>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component428>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
